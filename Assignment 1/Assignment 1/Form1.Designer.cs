namespace Assignment_1
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
            this.lblMyPokemon = new System.Windows.Forms.Label();
            this.btnAddPokemon = new System.Windows.Forms.Button();
            this.btnAddInfo = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblName2 = new System.Windows.Forms.Label();
            this.txtMoves = new System.Windows.Forms.TextBox();
            this.lblMoves = new System.Windows.Forms.Label();
            this.txtNature = new System.Windows.Forms.TextBox();
            this.lblNatures = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblMyPokemon
            // 
            this.lblMyPokemon.AutoSize = true;
            this.lblMyPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyPokemon.Location = new System.Drawing.Point(264, 24);
            this.lblMyPokemon.Name = "lblMyPokemon";
            this.lblMyPokemon.Size = new System.Drawing.Size(171, 31);
            this.lblMyPokemon.TabIndex = 1;
            this.lblMyPokemon.Text = "My Pokemon";
            // 
            // btnAddPokemon
            // 
            this.btnAddPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPokemon.Location = new System.Drawing.Point(192, 197);
            this.btnAddPokemon.Name = "btnAddPokemon";
            this.btnAddPokemon.Size = new System.Drawing.Size(301, 42);
            this.btnAddPokemon.TabIndex = 24;
            this.btnAddPokemon.Text = "Add Pokemon";
            this.btnAddPokemon.UseVisualStyleBackColor = true;
            this.btnAddPokemon.Click += new System.EventHandler(this.btnAddPokemon_Click);
            // 
            // btnAddInfo
            // 
            this.btnAddInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInfo.Location = new System.Drawing.Point(192, 384);
            this.btnAddInfo.Name = "btnAddInfo";
            this.btnAddInfo.Size = new System.Drawing.Size(301, 42);
            this.btnAddInfo.TabIndex = 25;
            this.btnAddInfo.Text = "Add Information";
            this.btnAddInfo.UseVisualStyleBackColor = true;
            this.btnAddInfo.Click += new System.EventHandler(this.btnAddInfo_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(51, 571);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(566, 222);
            this.txtResult.TabIndex = 30;
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName2.Location = new System.Drawing.Point(72, 267);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(126, 20);
            this.lblName2.TabIndex = 10;
            this.lblName2.Text = "Pokemon Name:";
            // 
            // txtMoves
            // 
            this.txtMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoves.Location = new System.Drawing.Point(204, 298);
            this.txtMoves.Name = "txtMoves";
            this.txtMoves.Size = new System.Drawing.Size(289, 26);
            this.txtMoves.TabIndex = 11;
            // 
            // lblMoves
            // 
            this.lblMoves.AutoSize = true;
            this.lblMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoves.Location = new System.Drawing.Point(72, 301);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(122, 20);
            this.lblMoves.TabIndex = 12;
            this.lblMoves.Text = "Possible Moves:";
            // 
            // txtNature
            // 
            this.txtNature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNature.Location = new System.Drawing.Point(204, 330);
            this.txtNature.Name = "txtNature";
            this.txtNature.Size = new System.Drawing.Size(289, 26);
            this.txtNature.TabIndex = 13;
            // 
            // lblNatures
            // 
            this.lblNatures.AutoSize = true;
            this.lblNatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNatures.Location = new System.Drawing.Point(76, 333);
            this.lblNatures.Name = "lblNatures";
            this.lblNatures.Size = new System.Drawing.Size(117, 20);
            this.lblNatures.TabIndex = 14;
            this.lblNatures.Text = "Viable Natures:";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(204, 264);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(289, 28);
            this.comboBox2.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 838);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnAddInfo);
            this.Controls.Add(this.btnAddPokemon);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblNatures);
            this.Controls.Add(this.txtNature);
            this.Controls.Add(this.lblMoves);
            this.Controls.Add(this.txtMoves);
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.lblMyPokemon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMyPokemon;
        private System.Windows.Forms.Button btnAddPokemon;
        private System.Windows.Forms.Button btnAddInfo;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.TextBox txtMoves;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.TextBox txtNature;
        private System.Windows.Forms.Label lblNatures;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

