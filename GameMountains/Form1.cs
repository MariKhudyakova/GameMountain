namespace GameMountains
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanelMainMenu = new System.Windows.Forms.TableLayoutPanel();
            this.NewStart = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.tableLayoutPanelMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMainMenu
            // 
            this.tableLayoutPanelMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelMainMenu.ColumnCount = 1;
            this.tableLayoutPanelMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMainMenu.Controls.Add(this.NewStart, 0, 0);
            this.tableLayoutPanelMainMenu.Controls.Add(this.Exit, 0, 1);
            this.tableLayoutPanelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMainMenu.Name = "tableLayoutPanelMainMenu";
            this.tableLayoutPanelMainMenu.RowCount = 2;
            this.tableLayoutPanelMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMainMenu.Size = new System.Drawing.Size(1036, 555);
            this.tableLayoutPanelMainMenu.TabIndex = 2;
            // 
            // NewStart
            // 
            this.NewStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NewStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewStart.Location = new System.Drawing.Point(418, 174);
            this.NewStart.Name = "NewStart";
            this.NewStart.Size = new System.Drawing.Size(200, 100);
            this.NewStart.TabIndex = 0;
            this.NewStart.Text = "Начать";
            this.NewStart.UseVisualStyleBackColor = true;
            this.NewStart.Click += new System.EventHandler(this.NewStart_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Exit.Location = new System.Drawing.Point(418, 280);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(200, 100);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            //this.Hide();
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1036, 555);
            this.Controls.Add(this.tableLayoutPanelMainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanelMainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Bitmap getFormBackgroundImage()
        {
            Bitmap bmp = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(this.BackgroundImage,
                    new Rectangle(0, 0, bmp.Width, bmp.Height));
            }
            return bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewStart_Click(object sender, EventArgs e)
        {
            bool create = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "InfAboutTheMountain")
                {
                    this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }

            if (create == false)
            {
                InfAboutTheMountain card = new InfAboutTheMountain();
                this.Hide();
                card.Show();
            }

            //if (Exit.Visible)
            //{
            //    Exit.Hide();
            //    NewStart.Hide();
            //    tableLayoutPanelMainMenu.Hide();
            //}
            //else
            //{
            //    Exit.Show();
            //}
        }
    }
}