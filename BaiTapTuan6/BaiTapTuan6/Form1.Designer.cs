namespace BaiTapTuan6
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
            this.gridViewResult = new System.Windows.Forms.DataGridView();
            this.btnGetList = new System.Windows.Forms.Button();
            this.btnGetListOutside = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.Label();
            this.btnAddToDoList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewResult
            // 
            this.gridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewResult.Location = new System.Drawing.Point(0, 0);
            this.gridViewResult.Name = "gridViewResult";
            this.gridViewResult.RowHeadersWidth = 51;
            this.gridViewResult.RowTemplate.Height = 24;
            this.gridViewResult.Size = new System.Drawing.Size(819, 245);
            this.gridViewResult.TabIndex = 0;
            // 
            // btnGetList
            // 
            this.btnGetList.Location = new System.Drawing.Point(0, 313);
            this.btnGetList.Name = "btnGetList";
            this.btnGetList.Size = new System.Drawing.Size(198, 46);
            this.btnGetList.TabIndex = 1;
            this.btnGetList.Text = "Lấy danh sách";
            this.btnGetList.UseVisualStyleBackColor = true;
            this.btnGetList.Click += new System.EventHandler(this.btnGetList_Click);
            // 
            // btnGetListOutside
            // 
            this.btnGetListOutside.Location = new System.Drawing.Point(308, 93);
            this.btnGetListOutside.Name = "btnGetListOutside";
            this.btnGetListOutside.Size = new System.Drawing.Size(198, 47);
            this.btnGetListOutside.TabIndex = 2;
            this.btnGetListOutside.Text = "Lấy danh sách (ngoài)";
            this.btnGetListOutside.UseVisualStyleBackColor = true;
            this.btnGetListOutside.Click += new System.EventHandler(this.btnGetListOutside_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "TaskName";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(21, 53);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(271, 22);
            this.txtTaskName.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 22);
            this.textBox2.TabIndex = 6;
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(18, 92);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(44, 16);
            this.txtStatus.TabIndex = 5;
            this.txtStatus.Text = "Status";
            // 
            // btnAddToDoList
            // 
            this.btnAddToDoList.Location = new System.Drawing.Point(308, 41);
            this.btnAddToDoList.Name = "btnAddToDoList";
            this.btnAddToDoList.Size = new System.Drawing.Size(198, 46);
            this.btnAddToDoList.TabIndex = 8;
            this.btnAddToDoList.Text = "Thêm vào danh sách (ngoài)";
            this.btnAddToDoList.UseVisualStyleBackColor = true;
            this.btnAddToDoList.Click += new System.EventHandler(this.btnAddToDoList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddToDoList);
            this.groupBox1.Controls.Add(this.btnGetListOutside);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.txtTaskName);
            this.groupBox1.Location = new System.Drawing.Point(276, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 166);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Try Another API";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGetList);
            this.Controls.Add(this.gridViewResult);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewResult;
        private System.Windows.Forms.Button btnGetList;
        private System.Windows.Forms.Button btnGetListOutside;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Button btnAddToDoList;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

