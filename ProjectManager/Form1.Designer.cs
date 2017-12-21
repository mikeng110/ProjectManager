using System.Drawing;

namespace ProjectManager
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
            this.tbx_project_name = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_transfer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lb_output = new System.Windows.Forms.Label();
            this.lbx_output = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_project_name
            // 
            this.tbx_project_name.Location = new System.Drawing.Point(16, 46);
            this.tbx_project_name.Name = "tbx_project_name";
            this.tbx_project_name.Size = new System.Drawing.Size(199, 20);
            this.tbx_project_name.TabIndex = 0;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(16, 281);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 1;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_transfer
            // 
            this.btn_transfer.Enabled = false;
            this.btn_transfer.Location = new System.Drawing.Point(197, 281);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Size = new System.Drawing.Size(75, 23);
            this.btn_transfer.TabIndex = 2;
            this.btn_transfer.Text = "Transfer";
            this.btn_transfer.UseVisualStyleBackColor = true;
            this.btn_transfer.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Project Name";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(221, 40);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(51, 31);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lb_output
            // 
            this.lb_output.AutoSize = true;
            this.lb_output.ForeColor = System.Drawing.Color.Green;
            this.lb_output.Location = new System.Drawing.Point(13, 9);
            this.lb_output.Name = "lb_output";
            this.lb_output.Size = new System.Drawing.Size(0, 13);
            this.lb_output.TabIndex = 5;
            // 
            // lbx_output
            // 
            this.lbx_output.FormattingEnabled = true;
            this.lbx_output.Location = new System.Drawing.Point(16, 102);
            this.lbx_output.Name = "lbx_output";
            this.lbx_output.Size = new System.Drawing.Size(256, 173);
            this.lbx_output.TabIndex = 6;
            this.lbx_output.SelectedIndexChanged += new System.EventHandler(this.lbx_output_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Existing Projects";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 316);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbx_output);
            this.Controls.Add(this.lb_output);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_transfer);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.tbx_project_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_project_name;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_transfer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lb_output;
        private System.Windows.Forms.ListBox lbx_output;
        private System.Windows.Forms.Label label2;
    }
}

