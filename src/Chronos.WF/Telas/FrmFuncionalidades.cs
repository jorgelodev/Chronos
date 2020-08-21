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
    public partial class FrmFuncionalidades : Form
    {
        public FrmFuncionalidades()
        {
            InitializeComponent();
        }

        private string UrlBase;
        private FuncionalidadeViewModel funcionalidadeSelecionada;

        private void FrmFuncionalidades_Load(object sender, EventArgs e)
        {
            UrlBase = ConfigurationManager.AppSettings["UrlBase"].ToString();
            CarregaFuncionalidades();
        }
        private void CarregaFuncionalidades()
        {
            dgFuncionalidades.Rows.Clear();

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = httpClient.GetAsync(UrlBase + $"funcionalidade/obter-por-codigofuncionalidade/{txtCodigoFuncionalidade.Text}").Result;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string conteudo = response.Content.ReadAsStringAsync().Result;

                    var projetos = JsonConvert.DeserializeObject<List<FuncionalidadeViewModel>>(conteudo);
                    foreach (var item in projetos)
                    {
                        dgFuncionalidades.Rows.Add(dgvcEditar.Image, dgvcExcluir.Image, item.Projeto.NomeProjeto,item.Menu.NomeMenu,item.CodigoFuncionalidade);
                        dgFuncionalidades.Rows[dgFuncionalidades.Rows.Count - 1].Tag = item;
                    }
                }
                else
                {
                    MessageBox.Show("Houve um erro com a API");
                }
            }
        }

        private void txtCodigoFuncionalidade_Enter(object sender, EventArgs e)
        {
            CarregaFuncionalidades();
        }
    }
}
