using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace PomodoroTimer
{
    public partial class Principal : Form
    {
        private bool _descanco = false;
        private int _minutosRestantes;
        private int _segundosRestantes;
        private int _ciclo = 0;

        public Principal()
        {
            InitializeComponent();
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (_descanco)
            {
                if (tmrDescanso.Enabled == false)
                    tmrDescanso.Enabled = true;
                else
                    tmrDescanso.Enabled = false;
            }
            else
            {
                if (tmrAtivo.Enabled == false)
                    tmrAtivo.Enabled = true;
                else
                    tmrAtivo.Enabled = false;
            }
        }

        private void tmrAtivo_Tick(object sender, EventArgs e)
        {
            if (!_descanco && prgPrincipal.Value != prgPrincipal.Maximum)
            {                
                prgPrincipal.Value += 1;
                _minutosRestantes = (1500 - prgPrincipal.Value) / 60;
                _segundosRestantes = (1500 - prgPrincipal.Value) % 60;

                lblTemporizador.Text = _minutosRestantes.ToString("D2") + ":" + _segundosRestantes.ToString("D2");
            }
            else
            {
                _ciclo++;
                tmrAtivo.Enabled = false;

                VerificarCiclo();
            }
        }

        private void VerificarCiclo()
        {
            switch (_ciclo)
            {
                case 1:
                    pnlMarcador1.BackColor = Color.Red;
                    PrepararTempoDeDescanco();
                    break;
                case 2:
                    pnlMarcador2.BackColor = Color.Red;
                    PrepararTempoDeDescanco();
                    break;
                case 3:
                    pnlMarcador3.BackColor = Color.Red;
                    PrepararTempoDeDescanco();
                    break;
                case 4:
                    pnlMarcador4.BackColor = Color.Red;
                    PrepararTempoDeDescanco();
                    break;
                case 5:
                    FinalizarCiclo();
                    break;
                default:
                    break;
            }
        }

        private void FinalizarCiclo()
        {
            _ciclo = 0;
            prgPrincipal.Value = 0;

            MessageBox.Show("Ciclos de atividade finalizados", "Aviso");
        }

        private void PrepararTempoDeDescanco()
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Inicie o tempo de descanço", "Aviso");

            _descanco = true;


            btnPlayPauseDescanso.Visible = true;

            prgPrincipal.Value = 0;
            prgPrincipal.Maximum = 30;

            lblTemporizador.ForeColor = Color.DodgerBlue;
        }

        private void tmrDescanso_Tick(object sender, EventArgs e)
        {
            if (_descanco && prgPrincipal.Value != prgPrincipal.Maximum)
            {
                prgPrincipal.Value += 1;
                _minutosRestantes = (30 - prgPrincipal.Value) / 60;
                _segundosRestantes = (30 - prgPrincipal.Value) % 60;

                lblTemporizador.Text = _minutosRestantes.ToString("D2") + ":" + _segundosRestantes.ToString("D2");                
            }
            else
            {
                tmrDescanso.Enabled = false;
                PrepararTempoDeAtividade();
            }
        }

        private void PrepararTempoDeAtividade()
        {
            MessageBox.Show("Inicie o tempo de atividade", "Aviso");
            SystemSounds.Exclamation.Play();

            _descanco = false;

            btnPlayPauseDescanso.Visible = false;

            prgPrincipal.Value = 0;
            prgPrincipal.Maximum = 1500;

            lblTemporizador.ForeColor = Color.Red;
        }
    }
}
