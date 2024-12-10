namespace Nasa_pawan
{
    partial class Form1
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
            button_houston = new Button();
            button_cape = new Button();
            label_houston = new Label();
            labelHouston = new Label();
            labelCape = new Label();
            labelStatus = new Label();
            SuspendLayout();
            // 
            // button_houston
            // 
            button_houston.Location = new Point(130, 131);
            button_houston.Name = "button_houston";
            button_houston.Size = new Size(117, 147);
            button_houston.TabIndex = 0;
            button_houston.Text = "Houston";
            button_houston.UseVisualStyleBackColor = true;
            button_houston.Click += button_houston_Click;
            // 
            // button_cape
            // 
            button_cape.Location = new Point(348, 131);
            button_cape.Name = "button_cape";
            button_cape.Size = new Size(117, 147);
            button_cape.TabIndex = 1;
            button_cape.Text = "Cape";
            button_cape.UseVisualStyleBackColor = true;
            button_cape.Click += button_cape_Click;
            // 
            // label_houston
            // 
            label_houston.AutoSize = true;
            label_houston.Location = new Point(130, 81);
            label_houston.Name = "label_houston";
            label_houston.Size = new Size(0, 20);
            label_houston.TabIndex = 2;
            // 
            // labelHouston
            // 
            labelHouston.AutoSize = true;
            labelHouston.Location = new Point(130, 97);
            labelHouston.Name = "labelHouston";
            labelHouston.Size = new Size(99, 20);
            labelHouston.TabIndex = 3;
            labelHouston.Text = "label houston";
            // 
            // labelCape
            // 
            labelCape.AutoSize = true;
            labelCape.Location = new Point(357, 97);
            labelCape.Name = "labelCape";
            labelCape.Size = new Size(78, 20);
            labelCape.TabIndex = 4;
            labelCape.Text = "label cape";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(271, 319);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(84, 20);
            labelStatus.TabIndex = 5;
            labelStatus.Text = "label status";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelStatus);
            Controls.Add(labelCape);
            Controls.Add(labelHouston);
            Controls.Add(label_houston);
            Controls.Add(button_cape);
            Controls.Add(button_houston);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_houston;
        private Button button_cape;
        private Label label_houston;
        private Label labelHouston;
        private Label labelCape;
        private Label labelStatus;
    }
}
