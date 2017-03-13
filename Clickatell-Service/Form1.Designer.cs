namespace Clickatell_Service
{
    partial class Form
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
            this.btn_sendsms = new System.Windows.Forms.Button();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_from = new System.Windows.Forms.TextBox();
            this.txt_delivery = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_api = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_sendsms
            // 
            this.btn_sendsms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendsms.Location = new System.Drawing.Point(135, 309);
            this.btn_sendsms.Name = "btn_sendsms";
            this.btn_sendsms.Size = new System.Drawing.Size(98, 32);
            this.btn_sendsms.TabIndex = 15;
            this.btn_sendsms.Text = "Send SMS";
            this.btn_sendsms.UseVisualStyleBackColor = true;
            this.btn_sendsms.Click += new System.EventHandler(this.btn_sendsms_Click);
            // 
            // txt_to
            // 
            this.txt_to.Location = new System.Drawing.Point(135, 97);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(186, 20);
            this.txt_to.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Recipient:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 37);
            this.label5.TabIndex = 16;
            this.label5.Text = "Clickatell: Test SMS ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Two-Way No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Delivery Time:";
            // 
            // txt_from
            // 
            this.txt_from.Location = new System.Drawing.Point(135, 129);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(186, 20);
            this.txt_from.TabIndex = 5;
            // 
            // txt_delivery
            // 
            this.txt_delivery.Location = new System.Drawing.Point(135, 161);
            this.txt_delivery.Name = "txt_delivery";
            this.txt_delivery.Size = new System.Drawing.Size(186, 20);
            this.txt_delivery.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Message:";
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(135, 193);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(186, 86);
            this.txt_message.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "API Key:";
            // 
            // txt_api
            // 
            this.txt_api.Location = new System.Drawing.Point(135, 66);
            this.txt_api.Name = "txt_api";
            this.txt_api.Size = new System.Drawing.Size(186, 20);
            this.txt_api.TabIndex = 3;
            // 
            // Form
            // 
            this.AcceptButton = this.btn_sendsms;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 358);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.txt_delivery);
            this.Controls.Add(this.txt_from);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_sendsms);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.txt_api);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form";
            this.Text = "Clickatell: Test SMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sendsms;
        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_from;
        private System.Windows.Forms.TextBox txt_delivery;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_api;
    }
}

