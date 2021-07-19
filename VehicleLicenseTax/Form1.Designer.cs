
namespace VehicleLicenseTax
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxCars = new System.Windows.Forms.ComboBox();
            this.comboBoxCC = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.calDateEnd = new System.Windows.Forms.DateTimePicker();
            this.radioButtonYear = new System.Windows.Forms.RadioButton();
            this.calDateStart = new System.Windows.Forms.DateTimePicker();
            this.radioButtonCustom = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(103, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用期間";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(103, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "載具種類";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(31, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "汽缸CC數/馬達馬力";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(625, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "試算結果";
            // 
            // lblResult
            // 
            this.lblResult.AutoEllipsis = true;
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblResult.Location = new System.Drawing.Point(22, 24);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(78, 22);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "使用期間\r\n";
            // 
            // comboBoxCars
            // 
            this.comboBoxCars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCars.FormattingEnabled = true;
            this.comboBoxCars.ItemHeight = 15;
            this.comboBoxCars.Location = new System.Drawing.Point(18, 177);
            this.comboBoxCars.Name = "comboBoxCars";
            this.comboBoxCars.Size = new System.Drawing.Size(306, 23);
            this.comboBoxCars.TabIndex = 10;
            this.comboBoxCars.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBoxCars.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBoxCars_MouseDown);
            // 
            // comboBoxCC
            // 
            this.comboBoxCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCC.FormattingEnabled = true;
            this.comboBoxCC.Items.AddRange(new object[] {
            "0"});
            this.comboBoxCC.Location = new System.Drawing.Point(18, 260);
            this.comboBoxCC.Name = "comboBoxCC";
            this.comboBoxCC.Size = new System.Drawing.Size(306, 23);
            this.comboBoxCC.TabIndex = 11;
            this.comboBoxCC.SelectedIndexChanged += new System.EventHandler(this.comboBoxCC_SelectedIndexChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSubmit.Location = new System.Drawing.Point(17, 23);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(112, 43);
            this.buttonSubmit.TabIndex = 12;
            this.buttonSubmit.TabStop = false;
            this.buttonSubmit.Text = "確定送出";
            this.buttonSubmit.UseMnemonic = false;
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.UseWaitCursor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonReset.Location = new System.Drawing.Point(172, 23);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(121, 43);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "取消重填";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBoxCC);
            this.panel2.Controls.Add(this.comboBoxCars);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(35, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 471);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.lblResult);
            this.panel3.Location = new System.Drawing.Point(484, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(418, 343);
            this.panel3.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSubmit);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Location = new System.Drawing.Point(18, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 74);
            this.panel1.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.calDateEnd);
            this.panel4.Controls.Add(this.radioButtonYear);
            this.panel4.Controls.Add(this.calDateStart);
            this.panel4.Controls.Add(this.radioButtonCustom);
            this.panel4.Location = new System.Drawing.Point(18, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(460, 71);
            this.panel4.TabIndex = 16;
            // 
            // calDateEnd
            // 
            this.calDateEnd.Location = new System.Drawing.Point(244, 43);
            this.calDateEnd.Name = "calDateEnd";
            this.calDateEnd.Size = new System.Drawing.Size(200, 25);
            this.calDateEnd.TabIndex = 13;
            this.calDateEnd.ValueChanged += new System.EventHandler(this.calDateEnd_ValueChanged);
            this.calDateEnd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.calDateEnd_MouseDown);
            // 
            // radioButtonYear
            // 
            this.radioButtonYear.AutoSize = true;
            this.radioButtonYear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButtonYear.Location = new System.Drawing.Point(17, 17);
            this.radioButtonYear.Name = "radioButtonYear";
            this.radioButtonYear.Size = new System.Drawing.Size(93, 29);
            this.radioButtonYear.TabIndex = 0;
            this.radioButtonYear.Text = "全年度";
            this.radioButtonYear.UseVisualStyleBackColor = true;
            this.radioButtonYear.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // calDateStart
            // 
            this.calDateStart.Location = new System.Drawing.Point(244, 12);
            this.calDateStart.Name = "calDateStart";
            this.calDateStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calDateStart.Size = new System.Drawing.Size(200, 25);
            this.calDateStart.TabIndex = 12;
            this.calDateStart.ValueChanged += new System.EventHandler(this.calDateStart_ValueChanged);
            this.calDateStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.calDateStart_MouseDown);
            // 
            // radioButtonCustom
            // 
            this.radioButtonCustom.AutoSize = true;
            this.radioButtonCustom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButtonCustom.Location = new System.Drawing.Point(129, 17);
            this.radioButtonCustom.Name = "radioButtonCustom";
            this.radioButtonCustom.Size = new System.Drawing.Size(93, 29);
            this.radioButtonCustom.TabIndex = 1;
            this.radioButtonCustom.Text = "依期間";
            this.radioButtonCustom.UseVisualStyleBackColor = true;
            this.radioButtonCustom.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(352, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 38);
            this.label5.TabIndex = 15;
            this.label5.Text = "使用牌照稅應納稅額試算";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 556);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "使用牌照稅應納稅額試算";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox comboBoxCars;
        private System.Windows.Forms.ComboBox comboBoxCC;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker calDateEnd;
        private System.Windows.Forms.DateTimePicker calDateStart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonCustom;
        private System.Windows.Forms.RadioButton radioButtonYear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
    }
}

