using System.Windows.Forms;
using ControlAsistencia.Negocio.Servicios;
namespace ControlAsistencia.Presentacion
{
    partial class FrmAsistencia : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()


        {
            lblTitulo = new Label();
            lblCurso = new Label();
            cmbCurso = new ComboBox();
            lblFecha = new Label();
            dgvAsistencia = new DataGridView();
            lblSubtitulo = new Label();
            dtpFecha = new DateTimePicker();
            btnPorcentaje = new Button();
            btnRegistrar = new Button();
            btnConsultar = new Button();
            btnModificar = new Button();
            pnlAzul = new Panel();
            txtEstudiante = new TextBox();
            chkPresente = new CheckBox();
            lblEstudiante = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).BeginInit();
            pnlAzul.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(554, 3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(281, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CONTROL DE ASISTENCIA";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            lblTitulo.UseWaitCursor = true;
            lblTitulo.Click += label1_Click;
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Location = new Point(59, 82);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(49, 20);
            lblCurso.TabIndex = 1;
            lblCurso.Text = "Curso:";
            lblCurso.UseWaitCursor = true;
            // 
            // cmbCurso
            // 
            cmbCurso.BackColor = SystemColors.Info;
            cmbCurso.FormattingEnabled = true;
            cmbCurso.Location = new Point(114, 78);
            cmbCurso.Name = "cmbCurso";
            cmbCurso.Size = new Size(151, 28);
            cmbCurso.TabIndex = 2;
            cmbCurso.Text = "Seleccionar curso...";
            cmbCurso.UseWaitCursor = true;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(844, 80);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 20);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha:";
            lblFecha.UseWaitCursor = true;
            // 
            // dgvAsistencia
            // 
            dgvAsistencia.AllowUserToAddRows = false;
            dgvAsistencia.AllowUserToResizeRows = false;
            dgvAsistencia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAsistencia.BackgroundColor = SystemColors.ActiveCaption;
            dgvAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencia.Location = new Point(25, 147);
            dgvAsistencia.Name = "dgvAsistencia";
            dgvAsistencia.ReadOnly = true;
            dgvAsistencia.RowHeadersWidth = 51;
            dgvAsistencia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAsistencia.Size = new Size(1100, 565);
            dgvAsistencia.TabIndex = 5;
            dgvAsistencia.UseWaitCursor = true;
            dgvAsistencia.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Location = new Point(595, 27);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(211, 20);
            lblSubtitulo.TabIndex = 6;
            lblSubtitulo.Text = "Sistema de gestión académica";
            lblSubtitulo.TextAlign = ContentAlignment.TopCenter;
            lblSubtitulo.UseWaitCursor = true;
            lblSubtitulo.Click += label4_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarMonthBackground = SystemColors.Info;
            dtpFecha.Location = new Point(897, 77);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(228, 27);
            dtpFecha.TabIndex = 7;
            dtpFecha.UseWaitCursor = true;
            // 
            // btnPorcentaje 
            // 
            btnPorcentaje.BackColor = SystemColors.Info;
            btnPorcentaje.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPorcentaje.Location = new Point(885, 728);
            btnPorcentaje.Name = "btnPorcentaje";
            btnPorcentaje.Size = new Size(240, 66);
            btnPorcentaje.TabIndex = 11;
            btnPorcentaje.Text = "Ver porcentajes de asistencia";
            btnPorcentaje.UseVisualStyleBackColor = false;
            btnPorcentaje.UseWaitCursor = true;
            btnPorcentaje.Click += button4_Click;
            // 
            // btnRegistrar 
            // 
            btnRegistrar.BackColor = SystemColors.Info;
            btnRegistrar.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(25, 729);
            btnRegistrar.Name = "btnRegistrar ";
            btnRegistrar.Size = new Size(240, 66);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar asistencia";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.UseWaitCursor = true;
            btnRegistrar.Click += button1_Click;
            // 
            // btnConsultar 
            // 
            btnConsultar.BackColor = SystemColors.Info;
            btnConsultar.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.Location = new Point(313, 728);
            btnConsultar.Name = "btnConsultar ";
            btnConsultar.Size = new Size(240, 66);
            btnConsultar.TabIndex = 13;
            btnConsultar.Text = "Consultar asistencia";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.UseWaitCursor = true;
            btnConsultar.Click += button2_Click;
            // 
            // btnModificar 
            // 
            btnModificar.BackColor = SystemColors.Info;
            btnModificar.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(599, 728);
            btnModificar.Name = "btnModificar ";
            btnModificar.Size = new Size(240, 66);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "Modificar asistencia";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.UseWaitCursor = true;
            btnModificar.Click += button3_Click;
            // 
            // pnlAzul
            // 
            pnlAzul.BackColor = SystemColors.Highlight;
            pnlAzul.Controls.Add(lblSubtitulo);
            pnlAzul.Controls.Add(lblTitulo);
            pnlAzul.Location = new Point(4, 6);
            pnlAzul.Name = "pnlAzul";
            pnlAzul.Size = new Size(1420, 58);
            pnlAzul.TabIndex = 15;
            pnlAzul.UseWaitCursor = true;
            // 
            // txtEstudiante
            // 
            txtEstudiante.Location = new Point(112, 114);
            txtEstudiante.Name = "txtEstudiante";
            txtEstudiante.Size = new Size(350, 27);
            txtEstudiante.TabIndex = 16;
            txtEstudiante.UseWaitCursor = true;
            // 
            // chkPresente 
            // 
            chkPresente.AutoSize = true;
            chkPresente.Location = new Point(468, 114);
            chkPresente.Name = "chkPresente";
            chkPresente.Size = new Size(87, 24);
            chkPresente.TabIndex = 17;
            chkPresente.Text = "Presente";
            chkPresente.UseVisualStyleBackColor = true;
            chkPresente.UseWaitCursor = true;
            // 
            // lblEstudiante
            // 
            lblEstudiante.AutoSize = true;
            lblEstudiante.Location = new Point(25, 117);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(81, 20);
            lblEstudiante.TabIndex = 18;
            lblEstudiante.Text = "Estudiante:";
            lblEstudiante.UseWaitCursor = true;
            lblEstudiante.Click += label1_Click_1;
            // 
            // FrmAsistencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1429, 804);
            Controls.Add(lblEstudiante);
            Controls.Add(chkPresente);
            Controls.Add(txtEstudiante);
            Controls.Add(btnModificar);
            Controls.Add(btnConsultar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnPorcentaje);
            Controls.Add(dtpFecha);
            Controls.Add(dgvAsistencia);
            Controls.Add(lblFecha);
            Controls.Add(cmbCurso);
            Controls.Add(lblCurso);
            Controls.Add(pnlAzul);
            Name = "FrmAsistencia";
            Text = "CONTROL DE ASISTENCIA";
            UseWaitCursor = true;
            Load += FrmAsistencia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).EndInit();
            pnlAzul.ResumeLayout(false);
            pnlAzul.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Comprobar que hay una fila seleccionada
                if (dgvAsistencia.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecciona un registro de asistencia.");
                    return;
                }

                // Obtener el ID del registro seleccionado
                int idAsistencia = Convert.ToInt32(
                    dgvAsistencia.SelectedRows[0].Cells["IdAsistencia"].Value
                );

                // Obtener el nuevo estado
                bool presente = chkPresente.Checked;

                // Modificar el registro
                asistenciaNegocio.ModificarAsistencia(
                    idAsistencia, presente
                );

                MessageBox.Show("Asistencia modificada correctamente.");

                // Actualizar la tabla
                CargarAsistencias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al modificar la asistencia: " + ex.Message
                );
            }
        }
        


        #endregion

        private Label lblTitulo;
        private Label lblCurso;
        private ComboBox cmbCurso;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private DataGridView dgvAsistencia;
        private Label lblSubtitulo;
        private DateTimePicker dtpF;
        private Button btnRegistrar;
        private Button btnPorcentaje;
        private Button btnConsultar;
        private Button btnModificar;
        private Panel pnlAzul;
        private TextBox txtEstudiante;
        private CheckBox chkPresente;

        private readonly CursoNegocio cursoNegocio = new CursoNegocio();

        private void CargarCursos()
        {
            try
            {
                cmbCurso.DataSource = cursoNegocio.ObtenerCursos();
                cmbCurso.DisplayMember = "Nombre";
                cmbCurso.ValueMember = "IdCurso";
                cmbCurso.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los cursos: " + ex.Message);
            }
        }
        private readonly AsistenciaNegocio asistenciaNegocio = new AsistenciaNegocio();
        private Label lblEstudiante;
    }
}
