namespace Gui
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnTest = new System.Windows.Forms.Button();
            this.toggleSwitch1 = new Gui.ToggleSwitch();
            this.newFormStyle1 = new Gui.Components.NewFormStyle(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.btnTest);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(150, 385);
            this.panelMenu.TabIndex = 0;
            // 
            // btnTest
            // 
            this.btnTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Exo Black", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTest.Image = global::Gui.Properties.Resources.gearW24;
            this.btnTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTest.Location = new System.Drawing.Point(0, 0);
            this.btnTest.Name = "btnTest";
            this.btnTest.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTest.Size = new System.Drawing.Size(150, 60);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = " Test";
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.BackColor = System.Drawing.Color.White;
            this.toggleSwitch1.BackColorOFF = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.toggleSwitch1.BackColorON = System.Drawing.Color.SlateBlue;
            this.toggleSwitch1.Checked = false;
            this.toggleSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleSwitch1.Font = new System.Drawing.Font("Verdana", 9F);
            this.toggleSwitch1.Location = new System.Drawing.Point(168, 12);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Size = new System.Drawing.Size(139, 22);
            this.toggleSwitch1.TabIndex = 1;
            this.toggleSwitch1.Text = "toggleSwitch1";
            this.toggleSwitch1.TextOnChecked = "";
            // 
            // newFormStyle1
            // 
            this.newFormStyle1.AllowUserResize = false;
            this.newFormStyle1.BackColor = System.Drawing.Color.White;
            this.newFormStyle1.ContextMenuForm = null;
            this.newFormStyle1.ControlBoxButtonsWidth = 60;
            this.newFormStyle1.EnableControlBoxIconsLight = false;
            this.newFormStyle1.EnableControlBoxMouseLight = false;
            this.newFormStyle1.Form = this;
            this.newFormStyle1.FormStyle = Gui.Components.NewFormStyle.fStyle.UserStyle;
            this.newFormStyle1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.newFormStyle1.HeaderColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.newFormStyle1.HeaderColorGradientEnable = true;
            this.newFormStyle1.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.newFormStyle1.HeaderHeight = 30;
            this.newFormStyle1.HeaderImage = null;
            this.newFormStyle1.HeaderTextColor = System.Drawing.Color.White;
            this.newFormStyle1.HeaderTextFont = new System.Drawing.Font("Exo Black", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newFormStyle1.IconSize = new System.Drawing.Size(25, 25);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Exo Black", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Image = global::Gui.Properties.Resources.gearW24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 60);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(150, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "Settings";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(629, 362);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.panelMenu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palladium";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnTest;
        private ToggleSwitch toggleSwitch1;
        private Components.NewFormStyle newFormStyle1;
        private System.Windows.Forms.Button button1;
    }
}

