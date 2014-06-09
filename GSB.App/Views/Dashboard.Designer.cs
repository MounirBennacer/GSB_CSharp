namespace GSB.App
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.vouchersLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.approvedAmountLabel = new System.Windows.Forms.Label();
            this.cancelExpenseButton = new System.Windows.Forms.Button();
            this.saveExpenseButton = new System.Windows.Forms.Button();
            this.expenseOPCostNum = new System.Windows.Forms.NumericUpDown();
            this.removeExpenseOPButton = new System.Windows.Forms.Button();
            this.addExpenseOPButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.expenseOPDate = new System.Windows.Forms.DateTimePicker();
            this.expensesOPList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.expenseOPLabelText = new System.Windows.Forms.TextBox();
            this.createExpenseButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.etpNum = new System.Windows.Forms.NumericUpDown();
            this.kmNum = new System.Windows.Forms.NumericUpDown();
            this.nuiNum = new System.Windows.Forms.NumericUpDown();
            this.repNum = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.expensesSelect = new System.Windows.Forms.ComboBox();
            this.conName = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseOPCostNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.etpNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuiNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNum)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vouchersLabel
            // 
            this.vouchersLabel.AutoSize = true;
            this.vouchersLabel.Location = new System.Drawing.Point(6, 51);
            this.vouchersLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.vouchersLabel.Name = "vouchersLabel";
            this.vouchersLabel.Size = new System.Drawing.Size(154, 13);
            this.vouchersLabel.TabIndex = 2;
            this.vouchersLabel.Text = "Nombre de justificatifs reçus : 0";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(6, 19);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(66, 13);
            this.stateLabel.TabIndex = 0;
            this.stateLabel.Text = "Etat : Aucun";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.vouchersLabel);
            this.groupBox3.Controls.Add(this.approvedAmountLabel);
            this.groupBox3.Controls.Add(this.stateLabel);
            this.groupBox3.Location = new System.Drawing.Point(23, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 72);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informations";
            // 
            // approvedAmountLabel
            // 
            this.approvedAmountLabel.AutoSize = true;
            this.approvedAmountLabel.Location = new System.Drawing.Point(6, 35);
            this.approvedAmountLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.approvedAmountLabel.Name = "approvedAmountLabel";
            this.approvedAmountLabel.Size = new System.Drawing.Size(124, 13);
            this.approvedAmountLabel.TabIndex = 1;
            this.approvedAmountLabel.Text = "Montant approuvé : 0,00";
            // 
            // cancelExpenseButton
            // 
            this.cancelExpenseButton.Location = new System.Drawing.Point(252, 373);
            this.cancelExpenseButton.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.cancelExpenseButton.Name = "cancelExpenseButton";
            this.cancelExpenseButton.Size = new System.Drawing.Size(196, 25);
            this.cancelExpenseButton.TabIndex = 14;
            this.cancelExpenseButton.Text = "Annuler la saisie";
            this.cancelExpenseButton.UseVisualStyleBackColor = true;
            // 
            // saveExpenseButton
            // 
            this.saveExpenseButton.Location = new System.Drawing.Point(23, 373);
            this.saveExpenseButton.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.saveExpenseButton.Name = "saveExpenseButton";
            this.saveExpenseButton.Size = new System.Drawing.Size(196, 25);
            this.saveExpenseButton.TabIndex = 13;
            this.saveExpenseButton.Text = "Sauvegarder";
            this.saveExpenseButton.UseVisualStyleBackColor = true;
            // 
            // expenseOPCostNum
            // 
            this.expenseOPCostNum.DecimalPlaces = 2;
            this.expenseOPCostNum.Location = new System.Drawing.Point(320, 70);
            this.expenseOPCostNum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.expenseOPCostNum.Name = "expenseOPCostNum";
            this.expenseOPCostNum.Size = new System.Drawing.Size(65, 20);
            this.expenseOPCostNum.TabIndex = 4;
            // 
            // removeExpenseOPButton
            // 
            this.removeExpenseOPButton.Location = new System.Drawing.Point(102, 105);
            this.removeExpenseOPButton.Margin = new System.Windows.Forms.Padding(0);
            this.removeExpenseOPButton.Name = "removeExpenseOPButton";
            this.removeExpenseOPButton.Size = new System.Drawing.Size(58, 20);
            this.removeExpenseOPButton.TabIndex = 7;
            this.removeExpenseOPButton.Text = "Enlever";
            this.removeExpenseOPButton.UseVisualStyleBackColor = true;
            // 
            // addExpenseOPButton
            // 
            this.addExpenseOPButton.Location = new System.Drawing.Point(7, 105);
            this.addExpenseOPButton.Margin = new System.Windows.Forms.Padding(0);
            this.addExpenseOPButton.Name = "addExpenseOPButton";
            this.addExpenseOPButton.Size = new System.Drawing.Size(65, 20);
            this.addExpenseOPButton.TabIndex = 6;
            this.addExpenseOPButton.Text = "Ajouter";
            this.addExpenseOPButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Montant :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Libellé :";
            // 
            // expenseOPDate
            // 
            this.expenseOPDate.Location = new System.Drawing.Point(185, 20);
            this.expenseOPDate.Name = "expenseOPDate";
            this.expenseOPDate.Size = new System.Drawing.Size(200, 20);
            this.expenseOPDate.TabIndex = 1;
            // 
            // expensesOPList
            // 
            this.expensesOPList.FormattingEnabled = true;
            this.expensesOPList.Location = new System.Drawing.Point(7, 20);
            this.expensesOPList.Name = "expensesOPList";
            this.expensesOPList.Size = new System.Drawing.Size(154, 82);
            this.expensesOPList.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.expenseOPCostNum);
            this.groupBox2.Controls.Add(this.removeExpenseOPButton);
            this.groupBox2.Controls.Add(this.addExpenseOPButton);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.expenseOPLabelText);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.expenseOPDate);
            this.groupBox2.Controls.Add(this.expensesOPList);
            this.groupBox2.Location = new System.Drawing.Point(23, 236);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 131);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eléments hors forfait";
            // 
            // expenseOPLabelText
            // 
            this.expenseOPLabelText.Location = new System.Drawing.Point(185, 70);
            this.expenseOPLabelText.Name = "expenseOPLabelText";
            this.expenseOPLabelText.Size = new System.Drawing.Size(125, 20);
            this.expenseOPLabelText.TabIndex = 3;
            // 
            // createExpenseButton
            // 
            this.createExpenseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createExpenseButton.Location = new System.Drawing.Point(30, 37);
            this.createExpenseButton.Name = "createExpenseButton";
            this.createExpenseButton.Size = new System.Drawing.Size(240, 23);
            this.createExpenseButton.TabIndex = 11;
            this.createExpenseButton.Text = "Créer une fiche de frais pour ce mois-ci";
            this.createExpenseButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Repas Restaurant";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nuitée Hôtel";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Frais Kilométrique";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Forfait Etape";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // etpNum
            // 
            this.etpNum.Location = new System.Drawing.Point(4, 25);
            this.etpNum.Name = "etpNum";
            this.etpNum.Size = new System.Drawing.Size(95, 20);
            this.etpNum.TabIndex = 4;
            this.etpNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kmNum
            // 
            this.kmNum.Location = new System.Drawing.Point(106, 25);
            this.kmNum.Name = "kmNum";
            this.kmNum.Size = new System.Drawing.Size(95, 20);
            this.kmNum.TabIndex = 5;
            this.kmNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nuiNum
            // 
            this.nuiNum.Location = new System.Drawing.Point(208, 25);
            this.nuiNum.Name = "nuiNum";
            this.nuiNum.Size = new System.Drawing.Size(95, 20);
            this.nuiNum.TabIndex = 6;
            this.nuiNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // repNum
            // 
            this.repNum.Location = new System.Drawing.Point(310, 25);
            this.repNum.Name = "repNum";
            this.repNum.Size = new System.Drawing.Size(98, 20);
            this.repNum.TabIndex = 7;
            this.repNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.etpNum, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.kmNum, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nuiNum, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.repNum, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 49);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 75);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eléments forfaitisés";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fiche de frais consultée :";
            // 
            // expensesSelect
            // 
            this.expensesSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expensesSelect.FormattingEnabled = true;
            this.expensesSelect.Location = new System.Drawing.Point(327, 37);
            this.expensesSelect.Name = "expensesSelect";
            this.expensesSelect.Size = new System.Drawing.Size(121, 21);
            this.expensesSelect.TabIndex = 8;
            // 
            // conName
            // 
            this.conName.Image = ((System.Drawing.Image)(resources.GetObject("conName.Image")));
            this.conName.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.conName.Location = new System.Drawing.Point(30, 8);
            this.conName.Name = "conName";
            this.conName.Size = new System.Drawing.Size(123, 23);
            this.conName.TabIndex = 16;
            this.conName.Text = "admin";
            this.conName.UseVisualStyleBackColor = true;
            this.conName.Click += new System.EventHandler(this.conName_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 414);
            this.Controls.Add(this.conName);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cancelExpenseButton);
            this.Controls.Add(this.saveExpenseButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.createExpenseButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expensesSelect);
            this.Name = "Dashboard";
            this.Text = "Fiche de saisie des frais";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseOPCostNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.etpNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuiNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNum)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vouchersLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label approvedAmountLabel;
        private System.Windows.Forms.Button cancelExpenseButton;
        private System.Windows.Forms.Button saveExpenseButton;
        private System.Windows.Forms.NumericUpDown expenseOPCostNum;
        private System.Windows.Forms.Button removeExpenseOPButton;
        private System.Windows.Forms.Button addExpenseOPButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker expenseOPDate;
        private System.Windows.Forms.ListBox expensesOPList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox expenseOPLabelText;
        private System.Windows.Forms.Button createExpenseButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown etpNum;
        private System.Windows.Forms.NumericUpDown kmNum;
        private System.Windows.Forms.NumericUpDown nuiNum;
        private System.Windows.Forms.NumericUpDown repNum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox expensesSelect;
        private System.Windows.Forms.Button conName;
    }
}

