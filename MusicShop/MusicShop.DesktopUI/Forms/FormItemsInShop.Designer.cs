﻿namespace MusicShop.DesktopUI
{
    partial class FormItemsInShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormItemsInShop));
            this.sss = new System.Windows.Forms.DataGridView();
            this.clnAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAlbumId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonToCart = new System.Windows.Forms.Button();
            this.buttonFromCart = new System.Windows.Forms.Button();
            this.dataGridViewInCart = new System.Windows.Forms.DataGridView();
            this.clnAlbumCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAlbumIdCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPriceCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAmountCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPriceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelItemsInShop = new System.Windows.Forms.Label();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonprintCheck = new System.Windows.Forms.Button();
            this.labelTotalPriceText = new System.Windows.Forms.Label();
            this.labelPriceTotalValue = new System.Windows.Forms.Label();
            this.labeShoppingCart = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.labelSeller = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInCart)).BeginInit();
            this.SuspendLayout();
            // 
            // sss
            // 
            this.sss.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.sss.AllowUserToAddRows = false;
            this.sss.AllowUserToDeleteRows = false;
            this.sss.AllowUserToResizeColumns = false;
            this.sss.AllowUserToResizeRows = false;
            this.sss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnAlbum,
            this.clnAlbumId,
            this.clnArtist,
            this.clnPrice,
            this.clnGenre,
            this.clnRating,
            this.clnAmount});
            this.sss.Location = new System.Drawing.Point(15, 113);
            this.sss.MultiSelect = false;
            this.sss.Name = "sss";
            this.sss.ReadOnly = true;
            this.sss.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sss.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.sss.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sss.Size = new System.Drawing.Size(808, 478);
            this.sss.TabIndex = 0;
            // 
            // clnAlbum
            // 
            this.clnAlbum.Frozen = true;
            this.clnAlbum.HeaderText = "Album";
            this.clnAlbum.Name = "clnAlbum";
            this.clnAlbum.ReadOnly = true;
            this.clnAlbum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnAlbum.Width = 200;
            // 
            // clnAlbumId
            // 
            this.clnAlbumId.Frozen = true;
            this.clnAlbumId.HeaderText = "Id";
            this.clnAlbumId.Name = "clnAlbumId";
            this.clnAlbumId.ReadOnly = true;
            this.clnAlbumId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnAlbumId.Visible = false;
            // 
            // clnArtist
            // 
            this.clnArtist.Frozen = true;
            this.clnArtist.HeaderText = "Artist";
            this.clnArtist.Name = "clnArtist";
            this.clnArtist.ReadOnly = true;
            this.clnArtist.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnArtist.Width = 200;
            // 
            // clnPrice
            // 
            this.clnPrice.Frozen = true;
            this.clnPrice.HeaderText = "Price";
            this.clnPrice.Name = "clnPrice";
            this.clnPrice.ReadOnly = true;
            this.clnPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnPrice.Width = 60;
            // 
            // clnGenre
            // 
            this.clnGenre.Frozen = true;
            this.clnGenre.HeaderText = "Genre";
            this.clnGenre.Name = "clnGenre";
            this.clnGenre.ReadOnly = true;
            this.clnGenre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnGenre.Width = 125;
            // 
            // clnRating
            // 
            this.clnRating.Frozen = true;
            this.clnRating.HeaderText = "AllMusic.com Rating";
            this.clnRating.Name = "clnRating";
            this.clnRating.ReadOnly = true;
            this.clnRating.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clnAmount
            // 
            this.clnAmount.Frozen = true;
            this.clnAmount.HeaderText = "Amount on storage";
            this.clnAmount.Name = "clnAmount";
            this.clnAmount.ReadOnly = true;
            this.clnAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnAmount.Width = 80;
            // 
            // buttonToCart
            // 
            this.buttonToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToCart.Location = new System.Drawing.Point(836, 230);
            this.buttonToCart.Name = "buttonToCart";
            this.buttonToCart.Size = new System.Drawing.Size(60, 39);
            this.buttonToCart.TabIndex = 1;
            this.buttonToCart.Text = ">>";
            this.buttonToCart.UseVisualStyleBackColor = true;
            this.buttonToCart.Click += new System.EventHandler(this.buttonToCart_Click);
            // 
            // buttonFromCart
            // 
            this.buttonFromCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFromCart.Location = new System.Drawing.Point(836, 360);
            this.buttonFromCart.Name = "buttonFromCart";
            this.buttonFromCart.Size = new System.Drawing.Size(60, 39);
            this.buttonFromCart.TabIndex = 2;
            this.buttonFromCart.Text = "<<";
            this.buttonFromCart.UseVisualStyleBackColor = true;
            this.buttonFromCart.Click += new System.EventHandler(this.buttonFromCart_Click);
            // 
            // dataGridViewInCart
            // 
            this.dataGridViewInCart.AllowUserToAddRows = false;
            this.dataGridViewInCart.AllowUserToDeleteRows = false;
            this.dataGridViewInCart.AllowUserToResizeColumns = false;
            this.dataGridViewInCart.AllowUserToResizeRows = false;
            this.dataGridViewInCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnAlbumCart,
            this.clnAlbumIdCart,
            this.clnPriceCart,
            this.clnAmountCart,
            this.clnPriceTotal});
            this.dataGridViewInCart.Location = new System.Drawing.Point(916, 113);
            this.dataGridViewInCart.MultiSelect = false;
            this.dataGridViewInCart.Name = "dataGridViewInCart";
            this.dataGridViewInCart.ReadOnly = true;
            this.dataGridViewInCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewInCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInCart.Size = new System.Drawing.Size(336, 405);
            this.dataGridViewInCart.TabIndex = 3;
            // 
            // clnAlbumCart
            // 
            this.clnAlbumCart.Frozen = true;
            this.clnAlbumCart.HeaderText = "Album";
            this.clnAlbumCart.Name = "clnAlbumCart";
            this.clnAlbumCart.ReadOnly = true;
            this.clnAlbumCart.Width = 150;
            // 
            // clnAlbumIdCart
            // 
            this.clnAlbumIdCart.Frozen = true;
            this.clnAlbumIdCart.HeaderText = "Id";
            this.clnAlbumIdCart.Name = "clnAlbumIdCart";
            this.clnAlbumIdCart.ReadOnly = true;
            this.clnAlbumIdCart.Visible = false;
            // 
            // clnPriceCart
            // 
            this.clnPriceCart.Frozen = true;
            this.clnPriceCart.HeaderText = "Item Price";
            this.clnPriceCart.Name = "clnPriceCart";
            this.clnPriceCart.ReadOnly = true;
            this.clnPriceCart.Visible = false;
            // 
            // clnAmountCart
            // 
            this.clnAmountCart.Frozen = true;
            this.clnAmountCart.HeaderText = "Amount";
            this.clnAmountCart.Name = "clnAmountCart";
            this.clnAmountCart.ReadOnly = true;
            this.clnAmountCart.Width = 75;
            // 
            // clnPriceTotal
            // 
            this.clnPriceTotal.Frozen = true;
            this.clnPriceTotal.HeaderText = "Price Cart item";
            this.clnPriceTotal.Name = "clnPriceTotal";
            this.clnPriceTotal.ReadOnly = true;
            this.clnPriceTotal.Width = 75;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(93, 78);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(157, 21);
            this.comboBoxGenre.TabIndex = 4;
            this.comboBoxGenre.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenre_SelectedIndexChanged);
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(15, 81);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(72, 13);
            this.labelGenre.TabIndex = 5;
            this.labelGenre.Text = "Genre Select:";
            // 
            // labelItemsInShop
            // 
            this.labelItemsInShop.AutoSize = true;
            this.labelItemsInShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelItemsInShop.Location = new System.Drawing.Point(362, 74);
            this.labelItemsInShop.Name = "labelItemsInShop";
            this.labelItemsInShop.Size = new System.Drawing.Size(107, 20);
            this.labelItemsInShop.TabIndex = 6;
            this.labelItemsInShop.Text = "Items in Shop";
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(1177, 568);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(75, 23);
            this.buttonClearAll.TabIndex = 8;
            this.buttonClearAll.Text = "Clear all";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonprintCheck
            // 
            this.buttonprintCheck.Location = new System.Drawing.Point(916, 568);
            this.buttonprintCheck.Name = "buttonprintCheck";
            this.buttonprintCheck.Size = new System.Drawing.Size(236, 23);
            this.buttonprintCheck.TabIndex = 9;
            this.buttonprintCheck.Text = "Print Check";
            this.buttonprintCheck.UseVisualStyleBackColor = true;
            this.buttonprintCheck.Click += new System.EventHandler(this.buttonprintCheck_Click);
            // 
            // labelTotalPriceText
            // 
            this.labelTotalPriceText.AutoSize = true;
            this.labelTotalPriceText.Location = new System.Drawing.Point(1192, 521);
            this.labelTotalPriceText.Name = "labelTotalPriceText";
            this.labelTotalPriceText.Size = new System.Drawing.Size(60, 13);
            this.labelTotalPriceText.TabIndex = 10;
            this.labelTotalPriceText.Text = "Total price:";
            // 
            // labelPriceTotalValue
            // 
            this.labelPriceTotalValue.AutoSize = true;
            this.labelPriceTotalValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelPriceTotalValue.Location = new System.Drawing.Point(1192, 543);
            this.labelPriceTotalValue.Name = "labelPriceTotalValue";
            this.labelPriceTotalValue.Size = new System.Drawing.Size(0, 13);
            this.labelPriceTotalValue.TabIndex = 11;
            // 
            // labeShoppingCart
            // 
            this.labeShoppingCart.AutoSize = true;
            this.labeShoppingCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeShoppingCart.Location = new System.Drawing.Point(1044, 74);
            this.labeShoppingCart.Name = "labeShoppingCart";
            this.labeShoppingCart.Size = new System.Drawing.Size(111, 20);
            this.labeShoppingCart.TabIndex = 14;
            this.labeShoppingCart.Text = "Shopping Cart";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(1177, 12);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 15;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // labelSeller
            // 
            this.labelSeller.AutoSize = true;
            this.labelSeller.Location = new System.Drawing.Point(1045, 17);
            this.labelSeller.Name = "labelSeller";
            this.labelSeller.Size = new System.Drawing.Size(0, 13);
            this.labelSeller.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 39);
            this.label2.TabIndex = 18;
            this.label2.Text = "H2O LICENCED CD\'s";
            // 
            // FormItemsInShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSeller);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.labeShoppingCart);
            this.Controls.Add(this.labelPriceTotalValue);
            this.Controls.Add(this.labelTotalPriceText);
            this.Controls.Add(this.buttonprintCheck);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.labelItemsInShop);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.dataGridViewInCart);
            this.Controls.Add(this.buttonFromCart);
            this.Controls.Add(this.buttonToCart);
            this.Controls.Add(this.sss);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormItemsInShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H2O Licenced CD\'s Main Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormItemsInShop_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.sss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonToCart;
        private System.Windows.Forms.Button buttonFromCart;
        private System.Windows.Forms.DataGridView dataGridViewInCart;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        public System.Windows.Forms.DataGridView sss;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAlbumId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAmount;
        private System.Windows.Forms.Label labelItemsInShop;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Button buttonprintCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAlbumCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAlbumIdCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPriceCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAmountCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPriceTotal;
        private System.Windows.Forms.Label labelTotalPriceText;
        private System.Windows.Forms.Label labelPriceTotalValue;
        private System.Windows.Forms.Label labeShoppingCart;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label labelSeller;
        private System.Windows.Forms.Label label2;
    }
}