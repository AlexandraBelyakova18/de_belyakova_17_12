namespace WindowsFormsApp4
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listViewRequests = new System.Windows.Forms.ListView();
            this.columnHeaderDescription = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderStatus = new System.Windows.Forms.ColumnHeader();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonAddRequest = new System.Windows.Forms.Button();
            this.buttonCompleteRequest = new System.Windows.Forms.Button();
            this.buttonDeleteRequest = new System.Windows.Forms.Button();
            this.buttonEditRequest = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // listViewRequests
            // 
            this.listViewRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDescription,
            this.columnHeaderStatus});
            this.listViewRequests.FullRowSelect = true;
            this.listViewRequests.GridLines = true;
            this.listViewRequests.Location = new System.Drawing.Point(12, 12);
            this.listViewRequests.Name = "listViewRequests";
            this.listViewRequests.Size = new System.Drawing.Size(360, 160);
            this.listViewRequests.TabIndex = 0;
            this.listViewRequests.UseCompatibleStateImageBehavior = false;
            this.listViewRequests.View = System.Windows.Forms.View.Details;

            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Описание";
            this.columnHeaderDescription.Width = 200;

            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Статус";
            this.columnHeaderStatus.Width = 100;

            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(12, 200);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(360, 20);
            this.textBoxDescription.TabIndex = 1;

            // 
            // buttonAddRequest
            // 
            this.buttonAddRequest.Location = new System.Drawing.Point(12, 230);
            this.buttonAddRequest.Name = "buttonAddRequest";
            this.buttonAddRequest.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRequest.TabIndex = 2;
            this.buttonAddRequest.Text = "Добавить";
            this.buttonAddRequest.UseVisualStyleBackColor = true;
            this.buttonAddRequest.Click += new System.EventHandler(this.buttonAddRequest_Click);

            // 
            // buttonCompleteRequest
            // 
            this.buttonCompleteRequest.Location = new System.Drawing.Point(93, 230);
            this.buttonCompleteRequest.Name = "buttonCompleteRequest";
            this.buttonCompleteRequest.Size = new System.Drawing.Size(75, 23);
            this.buttonCompleteRequest.TabIndex = 3;
            this.buttonCompleteRequest.Text = "Завершить";
            this.buttonCompleteRequest.UseVisualStyleBackColor = true;
            this.buttonCompleteRequest.Click += new System.EventHandler(this.buttonCompleteRequest_Click);

            // 
            // buttonDeleteRequest
            // 
            this.buttonDeleteRequest.Location = new System.Drawing.Point(174, 230);
            this.buttonDeleteRequest.Name = "buttonDeleteRequest";
            this.buttonDeleteRequest.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteRequest.TabIndex = 4;
            this.buttonDeleteRequest.Text = "Удалить";
            this.buttonDeleteRequest.UseVisualStyleBackColor = true;
            this.buttonDeleteRequest.Click += new System.EventHandler(this.buttonDeleteRequest_Click);

            // 
            // buttonEditRequest
            // 
            this.buttonEditRequest.Location = new System.Drawing.Point(255, 230);
            this.buttonEditRequest.Name = "buttonEditRequest";
            this.buttonEditRequest.Size = new System.Drawing.Size(75, 23);
            this.buttonEditRequest.TabIndex = 5;
            this.buttonEditRequest.Text = "Редактировать";
            this.buttonEditRequest.UseVisualStyleBackColor = true;
            this.buttonEditRequest.Click += new System.EventHandler(this.buttonEditRequest_Click);

            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 184);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(65, 13);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Описание:";

            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 301);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.buttonEditRequest);
            this.Controls.Add(this.buttonDeleteRequest);
            this.Controls.Add(this.buttonCompleteRequest);
            this.Controls.Add(this.buttonAddRequest);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.listViewRequests);
            this.Name = "FormMain";
            this.Text = "Заявки на ремонт";

            // Добавление ширины столбцов после инициализации компонентов
            listViewRequests.Columns[0].Width = -2; // Автоширина для первого столбца

            listViewRequests.Columns[1].Width = -2; // Автоширина для второго столбца

            // Завершение настройки формы
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListView listViewRequests;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonAddRequest;
        private System.Windows.Forms.Button buttonCompleteRequest;
        private System.Windows.Forms.Button buttonDeleteRequest;
        private System.Windows.Forms.Button buttonEditRequest;
        private System.Windows.Forms.Label labelDescription;
    }
}
