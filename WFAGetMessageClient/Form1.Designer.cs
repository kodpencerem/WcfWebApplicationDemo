namespace WFAGetMessageClient
{
    partial class frmGetMessage
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
            this.tbxGetMessage = new System.Windows.Forms.TextBox();
            this.btnGetMessage = new System.Windows.Forms.Button();
            this.lblGetMessageResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxGetMessage
            // 
            this.tbxGetMessage.Location = new System.Drawing.Point(34, 15);
            this.tbxGetMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxGetMessage.Name = "tbxGetMessage";
            this.tbxGetMessage.Size = new System.Drawing.Size(238, 22);
            this.tbxGetMessage.TabIndex = 0;
            // 
            // btnGetMessage
            // 
            this.btnGetMessage.Location = new System.Drawing.Point(280, 13);
            this.btnGetMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetMessage.Name = "btnGetMessage";
            this.btnGetMessage.Size = new System.Drawing.Size(152, 59);
            this.btnGetMessage.TabIndex = 1;
            this.btnGetMessage.Text = "Get Message";
            this.btnGetMessage.UseVisualStyleBackColor = true;
            this.btnGetMessage.Click += new System.EventHandler(this.btnGetMessage_Click);
            // 
            // lblGetMessageResult
            // 
            this.lblGetMessageResult.AutoSize = true;
            this.lblGetMessageResult.Location = new System.Drawing.Point(31, 56);
            this.lblGetMessageResult.Name = "lblGetMessageResult";
            this.lblGetMessageResult.Size = new System.Drawing.Size(51, 16);
            this.lblGetMessageResult.TabIndex = 2;
            this.lblGetMessageResult.Text = "Result";
            // 
            // frmGetMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.lblGetMessageResult);
            this.Controls.Add(this.btnGetMessage);
            this.Controls.Add(this.tbxGetMessage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGetMessage";
            this.Text = "Get Message Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxGetMessage;
        private System.Windows.Forms.Button btnGetMessage;
        private System.Windows.Forms.Label lblGetMessageResult;
    }
}

