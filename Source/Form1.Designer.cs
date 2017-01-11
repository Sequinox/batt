namespace BATT
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleBox = new System.Windows.Forms.TextBox();
            this.inputTextLabel = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.translationBox = new System.Windows.Forms.TextBox();
            this.translateButton = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.TextBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.BackColor = System.Drawing.SystemColors.Control;
            this.titleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleBox.Enabled = false;
            this.titleBox.Font = new System.Drawing.Font("Buba DEMO Outline", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(32, 5);
            this.titleBox.Name = "titleBox";
            this.titleBox.ReadOnly = true;
            this.titleBox.Size = new System.Drawing.Size(485, 93);
            this.titleBox.TabIndex = 0;
            this.titleBox.Text = "«BATT»";
            this.titleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.titleBox.TextChanged += new System.EventHandler(this.titleBox_TextChanged);
            // 
            // inputTextLabel
            // 
            this.inputTextLabel.AutoSize = true;
            this.inputTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextLabel.Location = new System.Drawing.Point(222, 162);
            this.inputTextLabel.Name = "inputTextLabel";
            this.inputTextLabel.Size = new System.Drawing.Size(98, 24);
            this.inputTextLabel.TabIndex = 1;
            this.inputTextLabel.Text = "Input Text:";
            this.inputTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Arimo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(90, 206);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(371, 70);
            this.inputBox.TabIndex = 2;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // translationBox
            // 
            this.translationBox.Font = new System.Drawing.Font("Arimo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translationBox.Location = new System.Drawing.Point(90, 363);
            this.translationBox.Multiline = true;
            this.translationBox.Name = "translationBox";
            this.translationBox.ReadOnly = true;
            this.translationBox.Size = new System.Drawing.Size(371, 70);
            this.translationBox.TabIndex = 4;
            this.translationBox.TextChanged += new System.EventHandler(this.translationBox_TextChanged);
            // 
            // translateButton
            // 
            this.translateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateButton.Location = new System.Drawing.Point(200, 298);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(147, 32);
            this.translateButton.TabIndex = 5;
            this.translateButton.Text = "Translate!";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // info
            // 
            this.info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Location = new System.Drawing.Point(90, 439);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.Size = new System.Drawing.Size(371, 83);
            this.info.TabIndex = 6;
            this.info.Text = resources.GetString("info.Text");
            this.info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(235, 336);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 7;
            this.copyButton.Text = "Copy Text";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorMessage.Enabled = false;
            this.errorMessage.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.HideSelection = false;
            this.errorMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.errorMessage.Location = new System.Drawing.Point(90, 104);
            this.errorMessage.Multiline = true;
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.ReadOnly = true;
            this.errorMessage.Size = new System.Drawing.Size(371, 55);
            this.errorMessage.TabIndex = 8;
            this.errorMessage.Text = "You have entered an invalid character or have met the 15 character limit. Please " +
    "only use alphabetic characters and keep your input under 15 characters.";
            this.errorMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.errorMessage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 524);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.info);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.translationBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.inputTextLabel);
            this.Controls.Add(this.titleBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BATT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label inputTextLabel;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox translationBox;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.TextBox errorMessage;
    }
}

