using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using trab_final_Gestao_Estufas.Models;

namespace trab_final_Gestao_Estufas
{
    public partial class FormEstufas : Form
    {
        private Task _taskAtualizacaoEstufas;
        private bool _atualizarEstufas = true;

        private Task _taskAtualizacaoIrrigacao;
        private bool _atualizarIrrigacao = false;

        private Task _taskAtualizacaoLogger;
        private bool _atualizarLogger = false;

        public FormEstufas()
        {
            InitializeComponent();

            rb_controle_irrigacao.Checked = false;
            rb_log_atmosferico.Checked = false;
            rb_gestor_estufas.Checked = true;

            IniciarAtualizacaoEstufas();
        }

        // --- LOGGER ATMOSFERICO ---
        private void IniciarAtualizacaoLogger()
        {
            if (_taskAtualizacaoLogger == null)
            {
                _atualizarLogger = true;
                _taskAtualizacaoLogger = Task.Run(async () =>
                {
                    var dao = new LoggerAtmosferico();
                    while (_atualizarLogger)
                    {
                        var logs = dao.Listar();
                        dgvEstufas.Invoke(new Action(() =>
                        {
                            dgvEstufas.DataSource = logs;
                        }));
                        await Task.Delay(1000);
                    }
                });
            }
        }

        private void PararAtualizacaoLogger()
        {
            _atualizarLogger = false;
            _taskAtualizacaoLogger = null;
        }

        private void AtualizarLoggerManual()
        {
            var dao = new LoggerAtmosferico();
            dgvEstufas.DataSource = dao.Listar();
        }

        // --- ESTUFAS ---
        private void RestaurarSelecaoEstufa(int? idEstufaSelecionado)
        {
            if (idEstufaSelecionado.HasValue)
            {
                foreach (DataGridViewRow row in dgvEstufas.Rows)
                {
                    if (row.Cells["IdEstufa"].Value != null &&
                        (int)row.Cells["IdEstufa"].Value == idEstufaSelecionado.Value)
                    {
                        row.Selected = true;
                        dgvEstufas.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
        }

        private void IniciarAtualizacaoEstufas()
        {
            if (_taskAtualizacaoEstufas == null)
            {
                _atualizarEstufas = true;
                _taskAtualizacaoEstufas = Task.Run(async () =>
                {
                    var dao = new GestorEstufas();
                    while (_atualizarEstufas)
                    {
                        int? idSelecionado = null;
                        dgvEstufas.Invoke(new Action(() =>
                        {
                            if (dgvEstufas.SelectedRows.Count > 0)
                                idSelecionado = (int)dgvEstufas.SelectedRows[0].Cells["IdEstufa"].Value;
                        }));

                        var estufas = dao.Listar();
                        dgvEstufas.Invoke(new Action(() =>
                        {
                            dgvEstufas.DataSource = estufas;
                            RestaurarSelecaoEstufa(idSelecionado);
                        }));
                        await Task.Delay(1000);
                    }
                });
            }
        }

        private void PararAtualizacaoEstufas()
        {
            _atualizarEstufas = false;
            _taskAtualizacaoEstufas = null;
        }

        private void AtualizarEstufasManual()
        {
            var dao = new GestorEstufas();
            dgvEstufas.DataSource = dao.Listar();
        }

        // --- IRRIGAÇÃO ---
        private void IniciarAtualizacaoIrrigacao()
        {
            if (_taskAtualizacaoIrrigacao == null)
            {
                _atualizarIrrigacao = true;
                _taskAtualizacaoIrrigacao = Task.Run(async () =>
                {
                    var dao = new ControleIrrigacao();
                    while (_atualizarIrrigacao)
                    {
                        var irrigacoes = dao.ObterIrrigacoes();
                        dgvEstufas.Invoke(new Action(() =>
                        {
                            dgvEstufas.DataSource = irrigacoes;
                        }));
                        await Task.Delay(1000);
                    }
                });
            }
        }

        private void PararAtualizacaoIrrigacao()
        {
            _atualizarIrrigacao = false;
            _taskAtualizacaoIrrigacao = null;
        }

        private void AtualizarIrrigacaoManual()
        {
            var dao = new ControleIrrigacao();
            dgvEstufas.DataSource = dao.ObterIrrigacoes();
        }

        // --- EVENTOS DOS RADIO BUTTONS ---
        private void rb_gestor_estufas_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_gestor_estufas.Checked)
            {
                panelGestorEstufas.Visible = true;
                panelControleIrrigacao.Visible = false;
                panelLogAtmosferico.Visible = false;

                PararAtualizacaoIrrigacao();
                PararAtualizacaoLogger();
                IniciarAtualizacaoEstufas();
                AtualizarEstufasManual();
            }
            else
            {
                PararAtualizacaoEstufas();
            }
        }

        private void rb_controle_irrigacao_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_controle_irrigacao.Checked)
            {
                panelControleIrrigacao.Visible = true;
                panelGestorEstufas.Visible = false;
                panelLogAtmosferico.Visible = false;

                PararAtualizacaoEstufas();
                PararAtualizacaoLogger();
                IniciarAtualizacaoIrrigacao();
                AtualizarIrrigacaoManual();
            }
            else
            {
                PararAtualizacaoIrrigacao();
            }
        }

        private void rb_log_atmosferico_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_log_atmosferico.Checked)
            {
                panelLogAtmosferico.Visible = true;
                panelGestorEstufas.Visible = false;
                panelControleIrrigacao.Visible = false;

                PararAtualizacaoEstufas();
                PararAtualizacaoIrrigacao();
                IniciarAtualizacaoLogger();
                AtualizarLoggerManual();
            }
            else
            {
                PararAtualizacaoLogger();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var estufa = new Estufa
            {
                Nome = txtNome.Text,
                Localizacao = txtLocalizacao.Text,
                Tamanho_m2 = int.Parse(txtTamanho_m2.Text),
                Cultura = txtCultura.Text
            };

            var dao = new GestorEstufas();
            dao.Inserir(estufa);
            MessageBox.Show("Estufa cadastrada com sucesso!");
            AtualizarEstufasManual();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dgvEstufas.SelectedRows.Count > 0)
            {
                var estufa = new Estufa
                {
                    IdEstufa = (int)dgvEstufas.SelectedRows[0].Cells["IdEstufa"].Value,
                    Nome = txtNome.Text,
                    Localizacao = txtLocalizacao.Text,
                    Tamanho_m2 = int.Parse(txtTamanho_m2.Text),
                    Cultura = txtCultura.Text
                };

                var dao = new GestorEstufas();
                dao.Atualizar(estufa);
                MessageBox.Show("Estufa atualizada com sucesso!");
                AtualizarEstufasManual();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvEstufas.SelectedRows.Count > 0)
            {
                int id = (int)dgvEstufas.SelectedRows[0].Cells["IdEstufa"].Value;
                var dao = new GestorEstufas();
                dao.Deletar(id);
                MessageBox.Show("Estufa excluída com sucesso!");
                AtualizarEstufasManual();
            }
        }

        private void btn_ligar_irrigacao_Click(object sender, EventArgs e)
        {
            // insere um evento de irrigação no banco de dados
            var irrigacao = new EventoIrrigacao
            {
                IdEstufa = int.Parse(txt_Id_estufa.Text),
                DataHora = DateTime.Now,
                DuracaoSegundos = int.Parse(num_duracao_irrigacao.Text)
            };

            var dao = new ControleIrrigacao();
            dao.AdicionarIrrigacao(irrigacao);
            MessageBox.Show("Irrigação iniciada com sucesso!");
            AtualizarIrrigacaoManual();
        }
    }
}
