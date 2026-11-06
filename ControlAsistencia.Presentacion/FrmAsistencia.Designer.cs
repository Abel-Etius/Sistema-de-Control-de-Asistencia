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
            label2 = new Label();
            cmbCurso = new ComboBox();
            label3 = new Label();
            dgvAsistencia = new DataGridView();
            label4 = new Label();
            dtpFecha = new DateTimePicker();
            button4 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            lblEstudiante = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).BeginInit();
            panel1.SuspendLayout();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 82);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Curso:";
            label2.UseWaitCursor = true;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(844, 80);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "Fecha:";
            label3.UseWaitCursor = true;
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
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(595, 27);
            label4.Name = "label4";
            label4.Size = new Size(211, 20);
            label4.TabIndex = 6;
            label4.Text = "Sistema de gestión académica";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.UseWaitCursor = true;
            label4.Click += label4_Click;
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
            // button4
            // 
            button4.BackColor = SystemColors.Info;
            button4.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(885, 728);
            button4.Name = "button4";
            button4.Size = new Size(240, 66);
            button4.TabIndex = 11;
            button4.Text = "Ver porcentajes de asistencia";
            button4.UseVisualStyleBackColor = false;
            button4.UseWaitCursor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(25, 729);
            button1.Name = "button1";
            button1.Size = new Size(240, 66);
            button1.TabIndex = 12;
            button1.Text = "Registrar asistencia";
            button1.UseVisualStyleBackColor = false;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(313, 728);
            button2.Name = "button2";
            button2.Size = new Size(240, 66);
            button2.TabIndex = 13;
            button2.Text = "Consultar asistencia";
            button2.UseVisualStyleBackColor = false;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(599, 728);
            button3.Name = "button3";
            button3.Size = new Size(240, 66);
            button3.TabIndex = 14;
            button3.Text = "Modificar asistencia";
            button3.UseVisualStyleBackColor = false;
            button3.UseWaitCursor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(4, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1420, 58);
            panel1.TabIndex = 15;
            panel1.UseWaitCursor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 27);
            textBox1.TabIndex = 16;
            textBox1.UseWaitCursor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(468, 114);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(87, 24);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Presente";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.UseWaitCursor = true;
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
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(dtpFecha);
            Controls.Add(dgvAsistencia);
            Controls.Add(label3);
            Controls.Add(cmbCurso);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "FrmAsistencia";
            Text = "CONTROL DE ASISTENCIA";
            UseWaitCursor = true;
            Load += FrmAsistencia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
                bool presente = checkBox1.Checked;

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
        private Label label2;
        private ComboBox cmbCurso;
        private Label label3;
        private DateTimePicker dtpFecha;
        private DataGridView dgvAsistencia;
        private Label label4;
        private DateTimePicker dtpF;
        private Button button4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private TextBox textBox1;
        private CheckBox checkBox1;
    
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
