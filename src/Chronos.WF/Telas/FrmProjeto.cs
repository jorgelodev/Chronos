using Chronos.API.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chronos.WF.Telas
{
    public partial class FrmProjeto : Form
    {
        public FrmProjeto()
        {
            InitializeComponent();
        }
        private string UrlBase;
        private ProjetoViewModel projetoSelecionado;
        private MenuViewModel menuSelecionado;
        private void Projeto_Load(object sender, EventArgs e)
        {
            UrlBase = ConfigurationManager.AppSettings["UrlBase"].ToString();

            CarregaProjeto();
        }
        private void CarregaProjeto()
        {
            dgProjetos.Rows.Clear();

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = httpClient.GetAsync(UrlBase + "projeto/").Result;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string conteudo = response.Content.ReadAsStringAsync().Result;

                    var projetos = JsonConvert.DeserializeObject<List<ProjetoViewModel>>(conteudo);
                    foreach (var item in projetos)
                    {
                        dgProjetos.Rows.Add(dgvcEditar.Image, dgvcExcluir.Image, item.NomeProjeto);
                        dgProjetos.Rows[dgProjetos.Rows.Count - 1].Tag = item;
                    }

                    CarregaComboProjeto(projetos);
                }
                else
                {
                    MessageBox.Show("Houve um erro com a API");
                }
            }
        }
        private void CarregaMenu()
        {
            dgMenus.Rows.Clear();
            if (cmbProjeto.SelectedValue== null || cmbProjeto.SelectedValue.ToString().Equals(""))
                return;

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = httpClient.GetAsync(UrlBase + $"menu/obter-por-projeto/{cmbProjeto.SelectedValue.ToString()}").Result;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string conteudo = response.Content.ReadAsStringAsync().Result;

                    var menus = JsonConvert.DeserializeObject<List<MenuViewModel>>(conteudo);
                    foreach (var item in menus)
                    {
                        dgMenus.Rows.Add(dgvcEditar.Image, dgvcExcluir.Image, item.NomeMenu);
                        dgMenus.Rows[dgMenus.Rows.Count - 1].Tag = item;
                    }
                }
                else
                {
                    MessageBox.Show("Houve um erro com a API");
                }
            }
        }
        private void CarregaComboProjeto(List<ProjetoViewModel> projetos)
        {
            cmbProjeto.DisplayMember = "NomeProjeto";
            cmbProjeto.ValueMember = "id";
            cmbProjeto.DataSource = projetos;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNomeProjeto.Text.Equals("") || txtPrefixoProjeto.Text.Equals(""))
            {
                MessageBox.Show("Campos obrigatórios");
                return;
            }

            if(projetoSelecionado!=null)
            {
                SalvarProjeto();
            }else
            {
                CadastrarProjeto();
            }            
        }
        private void CadastrarProjeto()
        {
            var NovoObjeto = new ProjetoViewModel()
            {
                Id = Guid.NewGuid(),
                NomeProjeto = txtNomeProjeto.Text,
                Prefixo = txtPrefixoProjeto.Text,
                Ativado = true
            };

            using (var httpClient = new HttpClient())
            {
                var response = httpClient.PostAsJsonAsync(UrlBase + "projeto/", NovoObjeto).Result;

                if (response.IsSuccessStatusCode)
                {
                    var objeto = JsonConvert.DeserializeObject<ProjetoViewModel>(response.Content.ReadAsStringAsync().Result);
                    if (!objeto.ValidationResult.IsValid)
                    {
                        var mensagem = "";
                        foreach (var item in objeto.ValidationResult.Errors)
                        {
                            mensagem += Environment.NewLine + "- " + item.ErrorMessage;
                        }
                        MessageBox.Show($"Não foi possível executar a ação, motivos:{mensagem}");
                        return;
                    }
                    limpar();
                    MessageBox.Show("Registro criado com sucesso!");
                    CarregaProjeto();
                }

            }
        }
        private void SalvarProjeto()
        {
            projetoSelecionado.NomeProjeto = txtNomeProjeto.Text;
            projetoSelecionado.Prefixo = txtPrefixoProjeto.Text;

            using (var httpClient = new HttpClient())
            {
                var serializedObjeto = JsonConvert.SerializeObject(projetoSelecionado);
                var content = new StringContent(serializedObjeto, Encoding.UTF8, "application/json");

                var response = httpClient.PutAsJsonAsync(UrlBase + "projeto/", projetoSelecionado).Result;

                if (response.IsSuccessStatusCode)
                {
                    var objeto = JsonConvert.DeserializeObject<ProjetoViewModel>(response.Content.ReadAsStringAsync().Result);
                    if (!objeto.ValidationResult.IsValid)
                    {
                        var mensagem = "";
                        foreach (var item in objeto.ValidationResult.Errors)
                        {
                            mensagem += Environment.NewLine + "- " + item.ErrorMessage;
                        }
                        MessageBox.Show($"Não foi possível executar a ação, motivos:{mensagem}");
                        return;
                    }
                    limpar();
                    MessageBox.Show("Registro salvo com sucesso!");
                    CarregaProjeto();
                }
            }
        }
        private void limpar()
        {
            txtNomeProjeto.Text = "";
            txtPrefixoProjeto.Text = "";
            btAdicionaProjeto.Text = "+ Adicionar";
            projetoSelecionado = null;


            txtNomeMenu.Text = "";
            txtPrefixoMenu.Text = "";
            btAdicionaMenu.Text = "+ Adicionar";
            menuSelecionado = null;
        }        

        private void dgProjetos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (dgvcEditar.Index == e.ColumnIndex)
                {
                    #region Editar
                    
                    projetoSelecionado = (ProjetoViewModel)dgProjetos.Rows[e.RowIndex].Tag;
                    txtNomeProjeto.Text = projetoSelecionado.NomeProjeto;
                    txtPrefixoProjeto.Text = projetoSelecionado.Prefixo;
                    btAdicionaProjeto.Text = "Salvar";
                    #endregion
                }
                else if (dgvcExcluir.Index == e.ColumnIndex)
                {
                    #region Excluir
                    if (MessageBox.Show("Deseja excluir o item selecionado?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        using (var httpClient = new HttpClient())
                        {
                            projetoSelecionado = (ProjetoViewModel)dgProjetos.Rows[e.RowIndex].Tag;

                            var serializedObjeto = JsonConvert.SerializeObject(projetoSelecionado);
                            var content = new StringContent(serializedObjeto, Encoding.UTF8, "application/json");

                            var response = httpClient.DeleteAsync(UrlBase + "projeto/" + projetoSelecionado.Id).Result;

                            if (response.IsSuccessStatusCode)
                            {
                                var objeto = JsonConvert.DeserializeObject<ProjetoViewModel>(response.Content.ReadAsStringAsync().Result);                                
                                if (objeto!= null && !objeto.ValidationResult.IsValid)
                                {
                                    var mensagem = "";
                                    foreach (var item in objeto.ValidationResult.Errors)
                                    {
                                        mensagem += Environment.NewLine + "- " + item.ErrorMessage;
                                    }
                                    MessageBox.Show($"Não foi possível executar a ação, motivos:{mensagem}");
                                    return;
                                }

                                MessageBox.Show("Item excluido com sucesso!");
                                CarregaProjeto();
                                limpar();
                            }

                        }
                    }
                    #endregion
                }
            }
        }

        private void btAdicionaMenu_Click(object sender, EventArgs e)
        {
            if (txtNomeMenu.Text.Equals("") || txtPrefixoMenu.Text.Equals("")||cmbProjeto.SelectedItem.ToString().Equals(""))
            {
                MessageBox.Show("Campos obrigatórios");
                return;
            }

            if (menuSelecionado != null)
            {
                SalvarMenu();
            }
            else
            {
                CadastrarMenu();
            }
        }
        private void CadastrarMenu()
        {            
            var NovoObjeto = new MenuViewModel()
            {
                Id = Guid.NewGuid(),
                ProjetoId = Guid.Parse(cmbProjeto.SelectedValue.ToString()),
                NomeMenu = txtNomeMenu.Text,
                Prefixo = txtPrefixoMenu.Text,
                Ativado = true
            };

            using (var httpClient = new HttpClient())
            {
                var response = httpClient.PostAsJsonAsync(UrlBase + "menu/", NovoObjeto).Result;

                if (response.IsSuccessStatusCode)
                {
                    var objeto = JsonConvert.DeserializeObject<MenuViewModel>(response.Content.ReadAsStringAsync().Result);
                    if (!objeto.ValidationResult.IsValid)
                    {
                        var mensagem = "";
                        foreach (var item in objeto.ValidationResult.Errors)
                        {
                            mensagem += Environment.NewLine + "- " + item.ErrorMessage;
                        }
                        MessageBox.Show($"Não foi possível executar a ação, motivos:{mensagem}");
                        return;
                    }
                    limpar();
                    MessageBox.Show("Registro criado com sucesso!");
                    CarregaMenu();
                }

            }
        }
        private void SalvarMenu()
        {
            menuSelecionado.NomeMenu = txtNomeMenu.Text;
            menuSelecionado.Prefixo = txtPrefixoMenu.Text;

            using (var httpClient = new HttpClient())
            {
                //var serializedObjeto = JsonConvert.SerializeObject(menuSelecionado);
                //var content = new StringContent(serializedObjeto, Encoding.UTF8, "application/json");

                try
                {
                    var response = httpClient.PutAsJsonAsync(UrlBase + "menu/", menuSelecionado).Result;
                
                if (response.IsSuccessStatusCode)
                {
                    var objeto = JsonConvert.DeserializeObject<MenuViewModel>(response.Content.ReadAsStringAsync().Result);
                    if (!objeto.ValidationResult.IsValid)
                    {
                        var mensagem = "";
                        foreach (var item in objeto.ValidationResult.Errors)
                        {
                            mensagem += Environment.NewLine + "- " + item.ErrorMessage;
                        }
                        MessageBox.Show($"Não foi possível executar a ação, motivos:{mensagem}");
                        return;
                    }
                    limpar();
                    MessageBox.Show("Registro salvo com sucesso!");
                    CarregaMenu();
                }
                }
                catch (Exception er)
                {
                    Console.WriteLine(er.Message);
                }
            }
        }

        private void dgMenus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (dgvmEditar.Index == e.ColumnIndex)
                {
                    #region Editar

                    menuSelecionado = (MenuViewModel)dgMenus.Rows[e.RowIndex].Tag;
                    txtNomeMenu.Text = menuSelecionado.NomeMenu;
                    txtPrefixoMenu.Text = menuSelecionado.Prefixo;
                    btAdicionaMenu.Text = "Salvar";
                    #endregion
                }
                else if (dgvmExcluir.Index == e.ColumnIndex)
                {
                    #region Excluir
                    if (MessageBox.Show("Deseja excluir o item selecionado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (var httpClient = new HttpClient())
                        {
                            menuSelecionado = (MenuViewModel)dgMenus.Rows[e.RowIndex].Tag;

                            var serializedObjeto = JsonConvert.SerializeObject(menuSelecionado);
                            var content = new StringContent(serializedObjeto, Encoding.UTF8, "application/json");

                            var response = httpClient.DeleteAsync(UrlBase + "menu/" + menuSelecionado.Id).Result;

                            if (response.IsSuccessStatusCode)
                            {
                                var objeto = JsonConvert.DeserializeObject<MenuViewModel>(response.Content.ReadAsStringAsync().Result);
                                if (objeto != null && !objeto.ValidationResult.IsValid)
                                {
                                    var mensagem = "";
                                    foreach (var item in objeto.ValidationResult.Errors)
                                    {
                                        mensagem += Environment.NewLine + "- " + item.ErrorMessage;
                                    }
                                    MessageBox.Show($"Não foi possível executar a ação, motivos:{mensagem}");
                                    return;
                                }

                                MessageBox.Show("Item excluido com sucesso!");
                                CarregaMenu();
                                limpar();
                            }

                        }
                    }
                    #endregion
                }
            }
        }
        private void cmbProjeto_SelectedValueChanged(object sender, EventArgs e)
        {
            CarregaMenu();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmFuncionalidades frm = new FrmFuncionalidades();
            frm.ProjetoId = Guid.Parse(cmbProjeto.SelectedValue.ToString());
            frm.ShowDialog();
        }
    }
}
