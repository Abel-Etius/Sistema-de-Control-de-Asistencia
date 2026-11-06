using System;
using System.Windows.Forms;
using ControlAsistencia.Negocio.Servicios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using ControlAsistencia.Negocio.Modelos;

namespace ControlAsistencia.Presentacion
{
    public partial class FrmAsistencia : Form
    {





        public FrmAsistencia()
        {
            InitializeComponent();
            CargarCursos();
        }

        // DateTimePicker dtpFecha; // Control declarado en el diseñador


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }




        
            private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCurso.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecciona un curso.");
                    return;
                }

                int idCurso = Convert.ToInt32(cmbCurso.SelectedValue);

                dgvAsistencia.DataSource =
                    asistenciaNegocio.CalcularPorcentajeAsistencia(idCurso);

                // Configurar encabezados
                dgvAsistencia.Columns["Estudiante"].HeaderText = "Estudiante";
                dgvAsistencia.Columns["TotalClases"].HeaderText = "Total de clases";
                dgvAsistencia.Columns["Asistencias"].HeaderText = "Asistencias";
                dgvAsistencia.Columns["PorcentajeAsistencia"].HeaderText = "Porcentaje (%)";

                // Ajustar presentación
                dgvAsistencia.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al calcular los porcentajes: " + ex.Message
                );
            }
        }
       

        private void FrmAsistencia_Load(object sender, EventArgs e)
        {

        }

        private void button1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            CargarAsistencias();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Comprobar que se seleccionó un curso
                if (cmbCurso.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecciona un curso.");
                    return;
                }

                // Obtener los datos
                int idCurso = Convert.ToInt32(cmbCurso.SelectedValue);
                DateTime fecha = dtpFecha.Value.Date;
                string estudiante = txtEstudiante.Text.Trim();
                bool presente = chkPresente.Checked;

                // Comprobar el nombre
                if (string.IsNullOrWhiteSpace(estudiante))
                {
                    MessageBox.Show("Escribe el nombre del estudiante.");
                    return;
                }

                // Registrar asistencia
                asistenciaNegocio.RegistrarAsistencia(
                    idCurso, estudiante, fecha, presente
                );

                MessageBox.Show("Asistencia registrada correctamente.");

                // Limpiar el campo del estudiante
                txtEstudiante.Clear();
                chkPresente.Checked = false;
                txtEstudiante.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo registrar la asistencia: " + ex.Message
                );
            }
        }
        private void CargarAsistencias()
        {
            try
            {
                if (cmbCurso.SelectedIndex == -1)
                    return;

                int idCurso = Convert.ToInt32(cmbCurso.SelectedValue);
                DateTime fecha = dtpFecha.Value.Date;

                List<Asistencia> asistencias =
                    asistenciaNegocio.ConsultarAsistencia(idCurso, fecha);

                dgvAsistencia.DataSource = null;
                dgvAsistencia.DataSource = asistencias;

                // Configuración general
                dgvAsistencia.ReadOnly = true;
                dgvAsistencia.AllowUserToAddRows = false;
                dgvAsistencia.AllowUserToDeleteRows = false;
                dgvAsistencia.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;
                dgvAsistencia.MultiSelect = false;
                dgvAsistencia.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                // Encabezados
                dgvAsistencia.ColumnHeadersHeight = 40;
                dgvAsistencia.ColumnHeadersDefaultCellStyle.Font =
                    new Font("Segoe UI", 10, FontStyle.Bold);

                // Filas
                dgvAsistencia.RowTemplate.Height = 35;
                dgvAsistencia.DefaultCellStyle.Font =
                    new Font("Segoe UI", 10);

                // Apariencia
                dgvAsistencia.BorderStyle = BorderStyle.None;
                dgvAsistencia.CellBorderStyle =
                    DataGridViewCellBorderStyle.SingleHorizontal;
                dgvAsistencia.RowHeadersVisible = false;

                if (dgvAsistencia.Columns["IdAsistencia"] is DataGridViewColumn idAsistenciaColumn)
                    idAsistenciaColumn.Visible = false;

                if (dgvAsistencia.Columns["IdCurso"] is DataGridViewColumn idCursoColumn)
                    idCursoColumn.Visible = false;

                if (dgvAsistencia.Columns["Estudiante"] is DataGridViewColumn estudianteColumn)
                    estudianteColumn.HeaderText = "Estudiante";

                if (dgvAsistencia.Columns["Fecha"] is DataGridViewColumn fechaColumn)
                    fechaColumn.HeaderText = "Fecha";

                if (dgvAsistencia.Columns["Presente"] is DataGridViewColumn presenteColumn)
                    presenteColumn.HeaderText = "Presente";
                dgvAsistencia.Columns["NombreCurso"].HeaderText = "Curso";
                dgvAsistencia.Columns["NombreCurso"].DisplayIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las asistencias: " + ex.Message);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellFormatting(
    object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 ||
                !dgvAsistencia.Columns.Contains("Presente"))
            {
                return;
            }

            object valor = dgvAsistencia.Rows[e.RowIndex]
                .Cells["Presente"].Value;

            if (valor == null || valor == DBNull.Value)
                return;

            bool presente = Convert.ToBoolean(valor);

            if (presente)
            {
                e.CellStyle.BackColor = Color.FromArgb(226, 245, 233);
                e.CellStyle.ForeColor = Color.FromArgb(30, 90, 50);
            }
            else
            {
                e.CellStyle.BackColor = Color.FromArgb(255, 235, 238);
                e.CellStyle.ForeColor = Color.FromArgb(150, 40, 40);
            }

            // Mostrar Presente o Ausente en lugar de True o False
            if (dgvAsistencia.Columns[e.ColumnIndex].Name == "Presente")
            {
                e.Value = presente ? "Presente" : "Ausente";
                e.FormattingApplied = true;
            }
        }
    }
        }
    
