using System.IO;
using System;

namespace PatternReformatter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.airForm1 = new ReaLTaiizor.Forms.AirForm();
            this.OutputDataTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.moonLabel1 = new ReaLTaiizor.Controls.MoonLabel();
            this.ToggleButton = new ReaLTaiizor.Controls.DungeonToggleButton();
            this.InputFormatTextBox = new ReaLTaiizor.Controls.HopeTextBox();
            this.nightLinkLabel1 = new ReaLTaiizor.Controls.NightLinkLabel();
            this.InputDataTextBox = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            this.materialButton2 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialButton3 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            this.airForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // airForm1
            // 
            this.airForm1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.airForm1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.airForm1.Controls.Add(this.OutputDataTextBox);
            this.airForm1.Controls.Add(this.pictureBox1);
            this.airForm1.Controls.Add(this.moonLabel1);
            this.airForm1.Controls.Add(this.ToggleButton);
            this.airForm1.Controls.Add(this.InputFormatTextBox);
            this.airForm1.Controls.Add(this.nightLinkLabel1);
            this.airForm1.Controls.Add(this.InputDataTextBox);
            this.airForm1.Controls.Add(this.materialButton2);
            this.airForm1.Controls.Add(this.materialButton3);
            this.airForm1.Controls.Add(this.materialButton1);
            this.airForm1.Customization = "AAAA/1paWv9ycnL/";
            this.airForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airForm1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F);
            this.airForm1.Image = ((System.Drawing.Image)(resources.GetObject("airForm1.Image")));
            this.airForm1.Location = new System.Drawing.Point(0, 0);
            this.airForm1.MaximumSize = new System.Drawing.Size(370, 557);
            this.airForm1.MinimumSize = new System.Drawing.Size(370, 557);
            this.airForm1.Movable = true;
            this.airForm1.Name = "airForm1";
            this.airForm1.NoRounding = false;
            this.airForm1.Sizable = true;
            this.airForm1.Size = new System.Drawing.Size(370, 557);
            this.airForm1.SmartBounds = true;
            this.airForm1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.airForm1.TabIndex = 0;
            this.airForm1.Text = "REFORMATTER";
            this.airForm1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.airForm1.Transparent = false;
            // 
            // OutputDataTextBox
            // 
            this.OutputDataTextBox.Location = new System.Drawing.Point(0, 343);
            this.OutputDataTextBox.Multiline = true;
            this.OutputDataTextBox.Name = "OutputDataTextBox";
            this.OutputDataTextBox.Size = new System.Drawing.Size(370, 115);
            this.OutputDataTextBox.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 464);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 93);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // moonLabel1
            // 
            this.moonLabel1.AutoSize = true;
            this.moonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.moonLabel1.ForeColor = System.Drawing.Color.Gray;
            this.moonLabel1.Location = new System.Drawing.Point(223, 309);
            this.moonLabel1.Name = "moonLabel1";
            this.moonLabel1.Size = new System.Drawing.Size(46, 16);
            this.moonLabel1.TabIndex = 31;
            this.moonLabel1.Text = "В файл";
            // 
            // ToggleButton
            // 
            this.ToggleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToggleButton.Location = new System.Drawing.Point(276, 303);
            this.ToggleButton.Name = "ToggleButton";
            this.ToggleButton.Size = new System.Drawing.Size(79, 27);
            this.ToggleButton.TabIndex = 30;
            this.ToggleButton.Text = "в файл";
            this.ToggleButton.Toggled = false;
            this.ToggleButton.ToggledBackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ToggleButton.ToggledBackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(237)))));
            this.ToggleButton.ToggledBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(89)))), ((int)(((byte)(55)))));
            this.ToggleButton.ToggledBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(89)))), ((int)(((byte)(55)))));
            this.ToggleButton.ToggledBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.ToggleButton.ToggledBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.ToggleButton.ToggledColorA = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(58)))));
            this.ToggleButton.ToggledColorB = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(113)))), ((int)(((byte)(63)))));
            this.ToggleButton.ToggledColorC = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ToggleButton.ToggledColorD = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ToggleButton.ToggledIOColorA = System.Drawing.Color.WhiteSmoke;
            this.ToggleButton.ToggledIOColorB = System.Drawing.Color.DimGray;
            this.ToggleButton.ToggledOnOffColorA = System.Drawing.Color.WhiteSmoke;
            this.ToggleButton.ToggledOnOffColorB = System.Drawing.Color.DimGray;
            this.ToggleButton.ToggledYesNoColorA = System.Drawing.Color.WhiteSmoke;
            this.ToggleButton.ToggledYesNoColorB = System.Drawing.Color.DimGray;
            this.ToggleButton.Type = ReaLTaiizor.Controls.DungeonToggleButton._Type.YesNo;
            // 
            // InputFormatTextBox
            // 
            this.InputFormatTextBox.BackColor = System.Drawing.Color.White;
            this.InputFormatTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.InputFormatTextBox.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.InputFormatTextBox.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.InputFormatTextBox.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputFormatTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.InputFormatTextBox.Hint = "1:2:3:4";
            this.InputFormatTextBox.Location = new System.Drawing.Point(12, 237);
            this.InputFormatTextBox.MaxLength = 32767;
            this.InputFormatTextBox.Multiline = false;
            this.InputFormatTextBox.Name = "InputFormatTextBox";
            this.InputFormatTextBox.PasswordChar = '\0';
            this.InputFormatTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InputFormatTextBox.SelectedText = "";
            this.InputFormatTextBox.SelectionLength = 0;
            this.InputFormatTextBox.SelectionStart = 0;
            this.InputFormatTextBox.Size = new System.Drawing.Size(343, 36);
            this.InputFormatTextBox.TabIndex = 29;
            this.InputFormatTextBox.TabStop = false;
            this.InputFormatTextBox.Text = "1:2";
            this.InputFormatTextBox.UseSystemPasswordChar = false;
            // 
            // nightLinkLabel1
            // 
            this.nightLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.nightLinkLabel1.AutoSize = true;
            this.nightLinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nightLinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.nightLinkLabel1.LinkColor = System.Drawing.Color.Black;
            this.nightLinkLabel1.Location = new System.Drawing.Point(12, 207);
            this.nightLinkLabel1.Name = "nightLinkLabel1";
            this.nightLinkLabel1.Size = new System.Drawing.Size(241, 15);
            this.nightLinkLabel1.TabIndex = 25;
            this.nightLinkLabel1.TabStop = true;
            this.nightLinkLabel1.Text = "Как указать шаблон для форматирования \r\n";
            this.nightLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.nightLinkLabel1.Click += new System.EventHandler(this.OpenInfoPopup_Click);
            // 
            // InputDataTextBox
            // 
            this.InputDataTextBox.AllowDrop = true;
            this.InputDataTextBox.AnimateReadOnly = false;
            this.InputDataTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InputDataTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.InputDataTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputDataTextBox.Depth = 0;
            this.InputDataTextBox.HideSelection = true;
            this.InputDataTextBox.Hint = "Ввести вручную:  username:password:email";
            this.InputDataTextBox.Location = new System.Drawing.Point(0, 108);
            this.InputDataTextBox.MaxLength = 32767;
            this.InputDataTextBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.InputDataTextBox.Name = "InputDataTextBox";
            this.InputDataTextBox.Padding = new System.Windows.Forms.Padding(6);
            this.InputDataTextBox.PasswordChar = '\0';
            this.InputDataTextBox.ReadOnly = false;
            this.InputDataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InputDataTextBox.SelectedText = "";
            this.InputDataTextBox.SelectionLength = 0;
            this.InputDataTextBox.SelectionStart = 0;
            this.InputDataTextBox.ShortcutsEnabled = true;
            this.InputDataTextBox.Size = new System.Drawing.Size(370, 82);
            this.InputDataTextBox.TabIndex = 17;
            this.InputDataTextBox.TabStop = false;
            this.InputDataTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.InputDataTextBox.UseSystemPasswordChar = false;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton2.Location = new System.Drawing.Point(12, 740);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(158, 36);
            this.materialButton2.TabIndex = 9;
            this.materialButton2.Text = "materialButton1";
            this.materialButton2.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton3.Location = new System.Drawing.Point(12, 51);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(96, 36);
            this.materialButton3.TabIndex = 9;
            this.materialButton3.Text = "Из файла";
            this.materialButton3.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton1.Location = new System.Drawing.Point(12, 298);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(151, 36);
            this.materialButton1.TabIndex = 9;
            this.materialButton1.Text = "Форматировать";
            this.materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.FormatButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(370, 557);
            this.Controls.Add(this.airForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(370, 557);
            this.MinimumSize = new System.Drawing.Size(370, 557);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REFORMATTER";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.airForm1.ResumeLayout(false);
            this.airForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.AirForm airForm1;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit InputDataTextBox;
        private ReaLTaiizor.Controls.NightLinkLabel nightLinkLabel1;
        private ReaLTaiizor.Controls.HopeTextBox InputFormatTextBox;
        private ReaLTaiizor.Controls.DungeonToggleButton ToggleButton;
        private ReaLTaiizor.Controls.MaterialButton materialButton2;
        private ReaLTaiizor.Controls.MoonLabel moonLabel1;
        private ReaLTaiizor.Controls.MaterialButton materialButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox OutputDataTextBox;
    }
}

