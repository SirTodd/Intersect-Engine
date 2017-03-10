﻿using DarkUI.Controls;

namespace Intersect_Editor.Forms
{
    partial class frmClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClass));
            this.grpClasses = new DarkUI.Controls.DarkGroupBox();
            this.lstClasses = new System.Windows.Forms.ListBox();
            this.grpItems = new DarkUI.Controls.DarkGroupBox();
            this.nudItemAmount = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbItem = new DarkUI.Controls.DarkComboBox();
            this.lblDropAmount = new System.Windows.Forms.Label();
            this.lblDropItem = new System.Windows.Forms.Label();
            this.scrlDropIndex = new DarkUI.Controls.DarkScrollBar();
            this.lblDropIndex = new System.Windows.Forms.Label();
            this.grpBaseStats = new DarkUI.Controls.DarkGroupBox();
            this.nudBaseMana = new DarkUI.Controls.DarkNumericUpDown();
            this.nudBaseHP = new DarkUI.Controls.DarkNumericUpDown();
            this.nudPoints = new DarkUI.Controls.DarkNumericUpDown();
            this.nudSpd = new DarkUI.Controls.DarkNumericUpDown();
            this.nudMR = new DarkUI.Controls.DarkNumericUpDown();
            this.nudDef = new DarkUI.Controls.DarkNumericUpDown();
            this.nudMag = new DarkUI.Controls.DarkNumericUpDown();
            this.nudAttack = new DarkUI.Controls.DarkNumericUpDown();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblMana = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblSpd = new System.Windows.Forms.Label();
            this.lblMR = new System.Windows.Forms.Label();
            this.lblDef = new System.Windows.Forms.Label();
            this.lblMag = new System.Windows.Forms.Label();
            this.lblAttack = new System.Windows.Forms.Label();
            this.grpGeneral = new DarkUI.Controls.DarkGroupBox();
            this.chkLocked = new DarkUI.Controls.DarkCheckBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new DarkUI.Controls.DarkTextBox();
            this.btnRemove = new DarkUI.Controls.DarkButton();
            this.btnAdd = new DarkUI.Controls.DarkButton();
            this.rbFemale = new DarkUI.Controls.DarkRadioButton();
            this.rbMale = new DarkUI.Controls.DarkRadioButton();
            this.lstSprites = new System.Windows.Forms.ListBox();
            this.cmbSprite = new DarkUI.Controls.DarkComboBox();
            this.lblSprite = new System.Windows.Forms.Label();
            this.picSprite = new System.Windows.Forms.PictureBox();
            this.grpSpells = new DarkUI.Controls.DarkGroupBox();
            this.nudLevel = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbSpell = new DarkUI.Controls.DarkComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblSpellNum = new System.Windows.Forms.Label();
            this.btnRemoveSpell = new DarkUI.Controls.DarkButton();
            this.btnAddSpell = new DarkUI.Controls.DarkButton();
            this.lstSpells = new System.Windows.Forms.ListBox();
            this.grpSpawnPoint = new DarkUI.Controls.DarkGroupBox();
            this.nudY = new DarkUI.Controls.DarkNumericUpDown();
            this.nudX = new DarkUI.Controls.DarkNumericUpDown();
            this.btnVisualMapSelector = new DarkUI.Controls.DarkButton();
            this.cmbWarpMap = new DarkUI.Controls.DarkComboBox();
            this.cmbDirection = new DarkUI.Controls.DarkComboBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblMap = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.grpCombat = new DarkUI.Controls.DarkGroupBox();
            this.nudScaling = new DarkUI.Controls.DarkNumericUpDown();
            this.nudCritChance = new DarkUI.Controls.DarkNumericUpDown();
            this.nudDamage = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbScalingStat = new DarkUI.Controls.DarkComboBox();
            this.lblScalingStat = new System.Windows.Forms.Label();
            this.lblScalingAmount = new System.Windows.Forms.Label();
            this.cmbDamageType = new DarkUI.Controls.DarkComboBox();
            this.lblDamageType = new System.Windows.Forms.Label();
            this.lblCritChance = new System.Windows.Forms.Label();
            this.cmbAttackAnimation = new DarkUI.Controls.DarkComboBox();
            this.lblAttackAnimation = new System.Windows.Forms.Label();
            this.lblDamage = new System.Windows.Forms.Label();
            this.grpRegen = new DarkUI.Controls.DarkGroupBox();
            this.nudMpRegen = new DarkUI.Controls.DarkNumericUpDown();
            this.nudHPRegen = new DarkUI.Controls.DarkNumericUpDown();
            this.lblHpRegen = new System.Windows.Forms.Label();
            this.lblManaRegen = new System.Windows.Forms.Label();
            this.lblRegenHint = new System.Windows.Forms.Label();
            this.grpLeveling = new DarkUI.Controls.DarkGroupBox();
            this.nudBaseExp = new DarkUI.Controls.DarkNumericUpDown();
            this.nudExpIncrease = new DarkUI.Controls.DarkNumericUpDown();
            this.lblExpIncrease = new System.Windows.Forms.Label();
            this.lblBaseExp = new System.Windows.Forms.Label();
            this.grpLevelBoosts = new DarkUI.Controls.DarkGroupBox();
            this.nudHpIncrease = new DarkUI.Controls.DarkNumericUpDown();
            this.nudMpIncrease = new DarkUI.Controls.DarkNumericUpDown();
            this.nudPointsIncrease = new DarkUI.Controls.DarkNumericUpDown();
            this.nudMagicResistIncrease = new DarkUI.Controls.DarkNumericUpDown();
            this.nudSpeedIncrease = new DarkUI.Controls.DarkNumericUpDown();
            this.nudMagicIncrease = new DarkUI.Controls.DarkNumericUpDown();
            this.nudArmorIncrease = new DarkUI.Controls.DarkNumericUpDown();
            this.nudStrengthIncrease = new DarkUI.Controls.DarkNumericUpDown();
            this.rdoPercentageIncrease = new DarkUI.Controls.DarkRadioButton();
            this.rdoStaticIncrease = new DarkUI.Controls.DarkRadioButton();
            this.lblPointsIncrease = new System.Windows.Forms.Label();
            this.lblHpIncrease = new System.Windows.Forms.Label();
            this.lblMpIncrease = new System.Windows.Forms.Label();
            this.lblSpeedIncrease = new System.Windows.Forms.Label();
            this.lblStrengthIncrease = new System.Windows.Forms.Label();
            this.lblMagicResistIncrease = new System.Windows.Forms.Label();
            this.lblArmorIncrease = new System.Windows.Forms.Label();
            this.lblMagicIncrease = new System.Windows.Forms.Label();
            this.grpSprite = new DarkUI.Controls.DarkGroupBox();
            this.lblFace = new System.Windows.Forms.Label();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.lblSpriteOptions = new System.Windows.Forms.Label();
            this.cmbFace = new DarkUI.Controls.DarkComboBox();
            this.grpGender = new DarkUI.Controls.DarkGroupBox();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.toolStrip = new DarkUI.Controls.DarkToolStrip();
            this.toolStripItemNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripItemPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemUndo = new System.Windows.Forms.ToolStripButton();
            this.grpClasses.SuspendLayout();
            this.grpItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemAmount)).BeginInit();
            this.grpBaseStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaseMana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaseHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttack)).BeginInit();
            this.grpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).BeginInit();
            this.grpSpells.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            this.grpSpawnPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.grpCombat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDamage)).BeginInit();
            this.grpRegen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMpRegen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHPRegen)).BeginInit();
            this.grpLeveling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaseExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpIncrease)).BeginInit();
            this.grpLevelBoosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHpIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMpIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointsIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagicResistIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeedIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagicIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArmorIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrengthIncrease)).BeginInit();
            this.grpSprite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.grpGender.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpClasses
            // 
            this.grpClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpClasses.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpClasses.Controls.Add(this.lstClasses);
            this.grpClasses.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpClasses.Location = new System.Drawing.Point(8, 36);
            this.grpClasses.Margin = new System.Windows.Forms.Padding(2);
            this.grpClasses.Name = "grpClasses";
            this.grpClasses.Padding = new System.Windows.Forms.Padding(2);
            this.grpClasses.Size = new System.Drawing.Size(135, 355);
            this.grpClasses.TabIndex = 15;
            this.grpClasses.TabStop = false;
            this.grpClasses.Text = "Classes";
            // 
            // lstClasses
            // 
            this.lstClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstClasses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstClasses.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstClasses.FormattingEnabled = true;
            this.lstClasses.Location = new System.Drawing.Point(4, 12);
            this.lstClasses.Margin = new System.Windows.Forms.Padding(2);
            this.lstClasses.Name = "lstClasses";
            this.lstClasses.Size = new System.Drawing.Size(129, 327);
            this.lstClasses.TabIndex = 1;
            this.lstClasses.Click += new System.EventHandler(this.lstClasses_Click);
            this.lstClasses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemList_KeyDown);
            // 
            // grpItems
            // 
            this.grpItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpItems.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpItems.Controls.Add(this.nudItemAmount);
            this.grpItems.Controls.Add(this.cmbItem);
            this.grpItems.Controls.Add(this.lblDropAmount);
            this.grpItems.Controls.Add(this.lblDropItem);
            this.grpItems.Controls.Add(this.scrlDropIndex);
            this.grpItems.Controls.Add(this.lblDropIndex);
            this.grpItems.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpItems.Location = new System.Drawing.Point(645, 0);
            this.grpItems.Margin = new System.Windows.Forms.Padding(2);
            this.grpItems.Name = "grpItems";
            this.grpItems.Padding = new System.Windows.Forms.Padding(2);
            this.grpItems.Size = new System.Drawing.Size(112, 163);
            this.grpItems.TabIndex = 18;
            this.grpItems.TabStop = false;
            this.grpItems.Text = "Starting Items";
            // 
            // nudItemAmount
            // 
            this.nudItemAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudItemAmount.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudItemAmount.Location = new System.Drawing.Point(8, 103);
            this.nudItemAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudItemAmount.Name = "nudItemAmount";
            this.nudItemAmount.Size = new System.Drawing.Size(92, 20);
            this.nudItemAmount.TabIndex = 62;
            this.nudItemAmount.ValueChanged += new System.EventHandler(this.nudItemAmount_ValueChanged);
            // 
            // cmbItem
            // 
            this.cmbItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbItem.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(8, 62);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(92, 21);
            this.cmbItem.TabIndex = 17;
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // lblDropAmount
            // 
            this.lblDropAmount.AutoSize = true;
            this.lblDropAmount.Location = new System.Drawing.Point(5, 87);
            this.lblDropAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDropAmount.Name = "lblDropAmount";
            this.lblDropAmount.Size = new System.Drawing.Size(46, 13);
            this.lblDropAmount.TabIndex = 15;
            this.lblDropAmount.Text = "Amount:";
            // 
            // lblDropItem
            // 
            this.lblDropItem.AutoSize = true;
            this.lblDropItem.Location = new System.Drawing.Point(5, 44);
            this.lblDropItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDropItem.Name = "lblDropItem";
            this.lblDropItem.Size = new System.Drawing.Size(30, 13);
            this.lblDropItem.TabIndex = 11;
            this.lblDropItem.Text = "Item:";
            // 
            // scrlDropIndex
            // 
            this.scrlDropIndex.Location = new System.Drawing.Point(7, 30);
            this.scrlDropIndex.Maximum = 9;
            this.scrlDropIndex.Name = "scrlDropIndex";
            this.scrlDropIndex.ScrollOrientation = DarkUI.Controls.DarkScrollOrientation.Horizontal;
            this.scrlDropIndex.Size = new System.Drawing.Size(94, 18);
            this.scrlDropIndex.TabIndex = 10;
            this.scrlDropIndex.ValueChanged += new System.EventHandler<DarkUI.Controls.ScrollValueEventArgs>(this.scrlDropIndex_Scroll);
            // 
            // lblDropIndex
            // 
            this.lblDropIndex.AutoSize = true;
            this.lblDropIndex.Location = new System.Drawing.Point(5, 14);
            this.lblDropIndex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDropIndex.Name = "lblDropIndex";
            this.lblDropIndex.Size = new System.Drawing.Size(68, 13);
            this.lblDropIndex.TabIndex = 9;
            this.lblDropIndex.Text = "Item Index: 1";
            // 
            // grpBaseStats
            // 
            this.grpBaseStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpBaseStats.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpBaseStats.Controls.Add(this.nudBaseMana);
            this.grpBaseStats.Controls.Add(this.nudBaseHP);
            this.grpBaseStats.Controls.Add(this.nudPoints);
            this.grpBaseStats.Controls.Add(this.nudSpd);
            this.grpBaseStats.Controls.Add(this.nudMR);
            this.grpBaseStats.Controls.Add(this.nudDef);
            this.grpBaseStats.Controls.Add(this.nudMag);
            this.grpBaseStats.Controls.Add(this.nudAttack);
            this.grpBaseStats.Controls.Add(this.lblPoints);
            this.grpBaseStats.Controls.Add(this.lblMana);
            this.grpBaseStats.Controls.Add(this.lblHP);
            this.grpBaseStats.Controls.Add(this.lblSpd);
            this.grpBaseStats.Controls.Add(this.lblMR);
            this.grpBaseStats.Controls.Add(this.lblDef);
            this.grpBaseStats.Controls.Add(this.lblMag);
            this.grpBaseStats.Controls.Add(this.lblAttack);
            this.grpBaseStats.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpBaseStats.Location = new System.Drawing.Point(2, 167);
            this.grpBaseStats.Margin = new System.Windows.Forms.Padding(2);
            this.grpBaseStats.Name = "grpBaseStats";
            this.grpBaseStats.Padding = new System.Windows.Forms.Padding(2);
            this.grpBaseStats.Size = new System.Drawing.Size(183, 177);
            this.grpBaseStats.TabIndex = 17;
            this.grpBaseStats.TabStop = false;
            this.grpBaseStats.Text = "Base Stats:";
            // 
            // nudBaseMana
            // 
            this.nudBaseMana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudBaseMana.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudBaseMana.Location = new System.Drawing.Point(98, 32);
            this.nudBaseMana.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudBaseMana.Name = "nudBaseMana";
            this.nudBaseMana.Size = new System.Drawing.Size(70, 20);
            this.nudBaseMana.TabIndex = 35;
            this.nudBaseMana.ValueChanged += new System.EventHandler(this.nudBaseMana_ValueChanged);
            // 
            // nudBaseHP
            // 
            this.nudBaseHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudBaseHP.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudBaseHP.Location = new System.Drawing.Point(9, 32);
            this.nudBaseHP.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudBaseHP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBaseHP.Name = "nudBaseHP";
            this.nudBaseHP.Size = new System.Drawing.Size(70, 20);
            this.nudBaseHP.TabIndex = 34;
            this.nudBaseHP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBaseHP.ValueChanged += new System.EventHandler(this.nudBaseHP_ValueChanged);
            // 
            // nudPoints
            // 
            this.nudPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudPoints.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudPoints.Location = new System.Drawing.Point(97, 144);
            this.nudPoints.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudPoints.Name = "nudPoints";
            this.nudPoints.Size = new System.Drawing.Size(70, 20);
            this.nudPoints.TabIndex = 33;
            this.nudPoints.ValueChanged += new System.EventHandler(this.nudPoints_ValueChanged);
            // 
            // nudSpd
            // 
            this.nudSpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSpd.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSpd.Location = new System.Drawing.Point(10, 144);
            this.nudSpd.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudSpd.Name = "nudSpd";
            this.nudSpd.Size = new System.Drawing.Size(70, 20);
            this.nudSpd.TabIndex = 32;
            this.nudSpd.ValueChanged += new System.EventHandler(this.nudSpd_ValueChanged);
            // 
            // nudMR
            // 
            this.nudMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMR.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMR.Location = new System.Drawing.Point(97, 105);
            this.nudMR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMR.Name = "nudMR";
            this.nudMR.Size = new System.Drawing.Size(70, 20);
            this.nudMR.TabIndex = 31;
            this.nudMR.ValueChanged += new System.EventHandler(this.nudMR_ValueChanged);
            // 
            // nudDef
            // 
            this.nudDef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDef.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDef.Location = new System.Drawing.Point(9, 105);
            this.nudDef.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudDef.Name = "nudDef";
            this.nudDef.Size = new System.Drawing.Size(70, 20);
            this.nudDef.TabIndex = 30;
            this.nudDef.ValueChanged += new System.EventHandler(this.nudDef_ValueChanged);
            // 
            // nudMag
            // 
            this.nudMag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMag.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMag.Location = new System.Drawing.Point(99, 66);
            this.nudMag.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMag.Name = "nudMag";
            this.nudMag.Size = new System.Drawing.Size(70, 20);
            this.nudMag.TabIndex = 29;
            this.nudMag.ValueChanged += new System.EventHandler(this.nudMag_ValueChanged);
            // 
            // nudAttack
            // 
            this.nudAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudAttack.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudAttack.Location = new System.Drawing.Point(10, 66);
            this.nudAttack.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudAttack.Name = "nudAttack";
            this.nudAttack.Size = new System.Drawing.Size(70, 20);
            this.nudAttack.TabIndex = 28;
            this.nudAttack.ValueChanged += new System.EventHandler(this.nudStr_ValueChanged);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(96, 128);
            this.lblPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(39, 13);
            this.lblPoints.TabIndex = 18;
            this.lblPoints.Text = "Points:";
            // 
            // lblMana
            // 
            this.lblMana.AutoSize = true;
            this.lblMana.Location = new System.Drawing.Point(96, 16);
            this.lblMana.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(37, 13);
            this.lblMana.TabIndex = 15;
            this.lblMana.Text = "Mana:";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(7, 16);
            this.lblHP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(25, 13);
            this.lblHP.TabIndex = 14;
            this.lblHP.Text = "HP:";
            // 
            // lblSpd
            // 
            this.lblSpd.AutoSize = true;
            this.lblSpd.Location = new System.Drawing.Point(7, 128);
            this.lblSpd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpd.Name = "lblSpd";
            this.lblSpd.Size = new System.Drawing.Size(71, 13);
            this.lblSpd.TabIndex = 9;
            this.lblSpd.Text = "Move Speed:";
            // 
            // lblMR
            // 
            this.lblMR.AutoSize = true;
            this.lblMR.Location = new System.Drawing.Point(94, 89);
            this.lblMR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMR.Name = "lblMR";
            this.lblMR.Size = new System.Drawing.Size(71, 13);
            this.lblMR.TabIndex = 8;
            this.lblMR.Text = "Magic Resist:";
            // 
            // lblDef
            // 
            this.lblDef.AutoSize = true;
            this.lblDef.Location = new System.Drawing.Point(9, 89);
            this.lblDef.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDef.Name = "lblDef";
            this.lblDef.Size = new System.Drawing.Size(37, 13);
            this.lblDef.TabIndex = 7;
            this.lblDef.Text = "Armor:";
            // 
            // lblMag
            // 
            this.lblMag.AutoSize = true;
            this.lblMag.Location = new System.Drawing.Point(96, 51);
            this.lblMag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMag.Name = "lblMag";
            this.lblMag.Size = new System.Drawing.Size(39, 13);
            this.lblMag.TabIndex = 6;
            this.lblMag.Text = "Magic:";
            // 
            // lblAttack
            // 
            this.lblAttack.AutoSize = true;
            this.lblAttack.Location = new System.Drawing.Point(7, 52);
            this.lblAttack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(41, 13);
            this.lblAttack.TabIndex = 5;
            this.lblAttack.Text = "Attack:";
            // 
            // grpGeneral
            // 
            this.grpGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpGeneral.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpGeneral.Controls.Add(this.chkLocked);
            this.grpGeneral.Controls.Add(this.lblName);
            this.grpGeneral.Controls.Add(this.txtName);
            this.grpGeneral.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpGeneral.Location = new System.Drawing.Point(1, 0);
            this.grpGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Padding = new System.Windows.Forms.Padding(2);
            this.grpGeneral.Size = new System.Drawing.Size(250, 41);
            this.grpGeneral.TabIndex = 19;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // chkLocked
            // 
            this.chkLocked.AutoSize = true;
            this.chkLocked.Location = new System.Drawing.Point(185, 14);
            this.chkLocked.Name = "chkLocked";
            this.chkLocked.Size = new System.Drawing.Size(62, 17);
            this.chkLocked.TabIndex = 14;
            this.chkLocked.Text = "Locked";
            this.chkLocked.CheckedChanged += new System.EventHandler(this.chkLocked_CheckedChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(5, 16);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtName.Location = new System.Drawing.Point(61, 14);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(118, 20);
            this.txtName.TabIndex = 12;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(9, 55);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(5);
            this.btnRemove.Size = new System.Drawing.Size(44, 19);
            this.btnRemove.TabIndex = 21;
            this.btnRemove.Text = "-";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 32);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(5);
            this.btnAdd.Size = new System.Drawing.Size(43, 19);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "+";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(5, 38);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 19;
            this.rbFemale.Text = "Female";
            this.rbFemale.Click += new System.EventHandler(this.rbFemale_Click);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(5, 18);
            this.rbMale.Margin = new System.Windows.Forms.Padding(2);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 18;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.Click += new System.EventHandler(this.rbMale_Click);
            // 
            // lstSprites
            // 
            this.lstSprites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstSprites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSprites.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstSprites.FormattingEnabled = true;
            this.lstSprites.Location = new System.Drawing.Point(57, 16);
            this.lstSprites.Margin = new System.Windows.Forms.Padding(2);
            this.lstSprites.Name = "lstSprites";
            this.lstSprites.Size = new System.Drawing.Size(91, 132);
            this.lstSprites.TabIndex = 17;
            this.lstSprites.Click += new System.EventHandler(this.lstSprites_Click);
            // 
            // cmbSprite
            // 
            this.cmbSprite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbSprite.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbSprite.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbSprite.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSprite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSprite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSprite.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSprite.FormattingEnabled = true;
            this.cmbSprite.Items.AddRange(new object[] {
            Strings.Get("general","none")});
            this.cmbSprite.Location = new System.Drawing.Point(272, 31);
            this.cmbSprite.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSprite.Name = "cmbSprite";
            this.cmbSprite.Size = new System.Drawing.Size(104, 21);
            this.cmbSprite.TabIndex = 16;
            this.cmbSprite.SelectedIndexChanged += new System.EventHandler(this.cmbSprite_SelectedIndexChanged);
            // 
            // lblSprite
            // 
            this.lblSprite.AutoSize = true;
            this.lblSprite.Location = new System.Drawing.Point(222, 16);
            this.lblSprite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSprite.Name = "lblSprite";
            this.lblSprite.Size = new System.Drawing.Size(37, 13);
            this.lblSprite.TabIndex = 15;
            this.lblSprite.Text = "Sprite:";
            // 
            // picSprite
            // 
            this.picSprite.BackColor = System.Drawing.Color.Black;
            this.picSprite.Location = new System.Drawing.Point(225, 31);
            this.picSprite.Margin = new System.Windows.Forms.Padding(2);
            this.picSprite.Name = "picSprite";
            this.picSprite.Size = new System.Drawing.Size(43, 42);
            this.picSprite.TabIndex = 14;
            this.picSprite.TabStop = false;
            // 
            // grpSpells
            // 
            this.grpSpells.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpSpells.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpSpells.Controls.Add(this.nudLevel);
            this.grpSpells.Controls.Add(this.cmbSpell);
            this.grpSpells.Controls.Add(this.lblLevel);
            this.grpSpells.Controls.Add(this.lblSpellNum);
            this.grpSpells.Controls.Add(this.btnRemoveSpell);
            this.grpSpells.Controls.Add(this.btnAddSpell);
            this.grpSpells.Controls.Add(this.lstSpells);
            this.grpSpells.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpSpells.Location = new System.Drawing.Point(189, 169);
            this.grpSpells.Margin = new System.Windows.Forms.Padding(2);
            this.grpSpells.Name = "grpSpells";
            this.grpSpells.Padding = new System.Windows.Forms.Padding(2);
            this.grpSpells.Size = new System.Drawing.Size(227, 175);
            this.grpSpells.TabIndex = 21;
            this.grpSpells.TabStop = false;
            this.grpSpells.Text = "Spells";
            // 
            // nudLevel
            // 
            this.nudLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudLevel.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudLevel.Location = new System.Drawing.Point(146, 58);
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(70, 20);
            this.nudLevel.TabIndex = 27;
            this.nudLevel.ValueChanged += new System.EventHandler(this.nudLevel_ValueChanged);
            // 
            // cmbSpell
            // 
            this.cmbSpell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbSpell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbSpell.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbSpell.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSpell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSpell.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSpell.FormattingEnabled = true;
            this.cmbSpell.Location = new System.Drawing.Point(108, 28);
            this.cmbSpell.Name = "cmbSpell";
            this.cmbSpell.Size = new System.Drawing.Size(108, 21);
            this.cmbSpell.TabIndex = 26;
            this.cmbSpell.SelectedIndexChanged += new System.EventHandler(this.cmbSpell_SelectedIndexChanged);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(105, 58);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(36, 13);
            this.lblLevel.TabIndex = 25;
            this.lblLevel.Text = "Level:";
            // 
            // lblSpellNum
            // 
            this.lblSpellNum.AutoSize = true;
            this.lblSpellNum.Location = new System.Drawing.Point(105, 12);
            this.lblSpellNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpellNum.Name = "lblSpellNum";
            this.lblSpellNum.Size = new System.Drawing.Size(33, 13);
            this.lblSpellNum.TabIndex = 23;
            this.lblSpellNum.Text = "Spell:";
            // 
            // btnRemoveSpell
            // 
            this.btnRemoveSpell.Location = new System.Drawing.Point(105, 114);
            this.btnRemoveSpell.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveSpell.Name = "btnRemoveSpell";
            this.btnRemoveSpell.Padding = new System.Windows.Forms.Padding(5);
            this.btnRemoveSpell.Size = new System.Drawing.Size(111, 21);
            this.btnRemoveSpell.TabIndex = 21;
            this.btnRemoveSpell.Text = "Remove";
            this.btnRemoveSpell.Click += new System.EventHandler(this.btnRemoveSpell_Click);
            // 
            // btnAddSpell
            // 
            this.btnAddSpell.Location = new System.Drawing.Point(105, 89);
            this.btnAddSpell.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSpell.Name = "btnAddSpell";
            this.btnAddSpell.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddSpell.Size = new System.Drawing.Size(111, 21);
            this.btnAddSpell.TabIndex = 20;
            this.btnAddSpell.Text = "Add";
            this.btnAddSpell.Click += new System.EventHandler(this.btnAddSpell_Click);
            // 
            // lstSpells
            // 
            this.lstSpells.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstSpells.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSpells.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstSpells.FormattingEnabled = true;
            this.lstSpells.Location = new System.Drawing.Point(4, 17);
            this.lstSpells.Margin = new System.Windows.Forms.Padding(2);
            this.lstSpells.Name = "lstSpells";
            this.lstSpells.Size = new System.Drawing.Size(93, 119);
            this.lstSpells.TabIndex = 17;
            this.lstSpells.SelectedIndexChanged += new System.EventHandler(this.lstSpells_SelectedIndexChanged);
            // 
            // grpSpawnPoint
            // 
            this.grpSpawnPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpSpawnPoint.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpSpawnPoint.Controls.Add(this.nudY);
            this.grpSpawnPoint.Controls.Add(this.nudX);
            this.grpSpawnPoint.Controls.Add(this.btnVisualMapSelector);
            this.grpSpawnPoint.Controls.Add(this.cmbWarpMap);
            this.grpSpawnPoint.Controls.Add(this.cmbDirection);
            this.grpSpawnPoint.Controls.Add(this.lblDir);
            this.grpSpawnPoint.Controls.Add(this.lblY);
            this.grpSpawnPoint.Controls.Add(this.lblX);
            this.grpSpawnPoint.Controls.Add(this.lblMap);
            this.grpSpawnPoint.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpSpawnPoint.Location = new System.Drawing.Point(2, 45);
            this.grpSpawnPoint.Margin = new System.Windows.Forms.Padding(2);
            this.grpSpawnPoint.Name = "grpSpawnPoint";
            this.grpSpawnPoint.Padding = new System.Windows.Forms.Padding(2);
            this.grpSpawnPoint.Size = new System.Drawing.Size(249, 118);
            this.grpSpawnPoint.TabIndex = 27;
            this.grpSpawnPoint.TabStop = false;
            this.grpSpawnPoint.Text = "Spawn Point";
            // 
            // nudY
            // 
            this.nudY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudY.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudY.Location = new System.Drawing.Point(179, 43);
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(64, 20);
            this.nudY.TabIndex = 26;
            this.nudY.ValueChanged += new System.EventHandler(this.nudY_ValueChanged);
            // 
            // nudX
            // 
            this.nudX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudX.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudX.Location = new System.Drawing.Point(179, 17);
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(64, 20);
            this.nudX.TabIndex = 25;
            this.nudX.ValueChanged += new System.EventHandler(this.nudX_ValueChanged);
            // 
            // btnVisualMapSelector
            // 
            this.btnVisualMapSelector.Location = new System.Drawing.Point(36, 78);
            this.btnVisualMapSelector.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisualMapSelector.Name = "btnVisualMapSelector";
            this.btnVisualMapSelector.Padding = new System.Windows.Forms.Padding(5);
            this.btnVisualMapSelector.Size = new System.Drawing.Size(207, 25);
            this.btnVisualMapSelector.TabIndex = 24;
            this.btnVisualMapSelector.Text = "Open Visual Interface";
            this.btnVisualMapSelector.Click += new System.EventHandler(this.btnVisualMapSelector_Click);
            // 
            // cmbWarpMap
            // 
            this.cmbWarpMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbWarpMap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbWarpMap.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbWarpMap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbWarpMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWarpMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbWarpMap.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbWarpMap.FormattingEnabled = true;
            this.cmbWarpMap.Location = new System.Drawing.Point(36, 16);
            this.cmbWarpMap.Margin = new System.Windows.Forms.Padding(2);
            this.cmbWarpMap.Name = "cmbWarpMap";
            this.cmbWarpMap.Size = new System.Drawing.Size(121, 21);
            this.cmbWarpMap.TabIndex = 12;
            this.cmbWarpMap.SelectedIndexChanged += new System.EventHandler(this.cmbWarpMap_SelectedIndexChanged);
            // 
            // cmbDirection
            // 
            this.cmbDirection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbDirection.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbDirection.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbDirection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDirection.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbDirection.FormattingEnabled = true;
            this.cmbDirection.Items.AddRange(new object[] {
            "Up",
            "Down",
            "Left",
            "Right"});
            this.cmbDirection.Location = new System.Drawing.Point(36, 42);
            this.cmbDirection.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDirection.Name = "cmbDirection";
            this.cmbDirection.Size = new System.Drawing.Size(121, 21);
            this.cmbDirection.TabIndex = 23;
            this.cmbDirection.SelectedIndexChanged += new System.EventHandler(this.cmbDirection_SelectedIndexChanged);
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(9, 45);
            this.lblDir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(23, 13);
            this.lblDir.TabIndex = 22;
            this.lblDir.Text = "Dir:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(161, 45);
            this.lblY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 13);
            this.lblY.TabIndex = 11;
            this.lblY.Text = "Y:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(161, 19);
            this.lblX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 13);
            this.lblX.TabIndex = 10;
            this.lblX.Text = "X:";
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Location = new System.Drawing.Point(7, 20);
            this.lblMap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(31, 13);
            this.lblMap.TabIndex = 9;
            this.lblMap.Text = "Map:";
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.Controls.Add(this.grpCombat);
            this.pnlContainer.Controls.Add(this.grpRegen);
            this.pnlContainer.Controls.Add(this.grpLeveling);
            this.pnlContainer.Controls.Add(this.grpSprite);
            this.pnlContainer.Controls.Add(this.grpSpawnPoint);
            this.pnlContainer.Controls.Add(this.grpGeneral);
            this.pnlContainer.Controls.Add(this.grpSpells);
            this.pnlContainer.Controls.Add(this.grpBaseStats);
            this.pnlContainer.Controls.Add(this.grpItems);
            this.pnlContainer.Location = new System.Drawing.Point(147, 36);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(780, 355);
            this.pnlContainer.TabIndex = 28;
            this.pnlContainer.Visible = false;
            // 
            // grpCombat
            // 
            this.grpCombat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpCombat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpCombat.Controls.Add(this.nudScaling);
            this.grpCombat.Controls.Add(this.nudCritChance);
            this.grpCombat.Controls.Add(this.nudDamage);
            this.grpCombat.Controls.Add(this.cmbScalingStat);
            this.grpCombat.Controls.Add(this.lblScalingStat);
            this.grpCombat.Controls.Add(this.lblScalingAmount);
            this.grpCombat.Controls.Add(this.cmbDamageType);
            this.grpCombat.Controls.Add(this.lblDamageType);
            this.grpCombat.Controls.Add(this.lblCritChance);
            this.grpCombat.Controls.Add(this.cmbAttackAnimation);
            this.grpCombat.Controls.Add(this.lblAttackAnimation);
            this.grpCombat.Controls.Add(this.lblDamage);
            this.grpCombat.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpCombat.Location = new System.Drawing.Point(537, 169);
            this.grpCombat.Name = "grpCombat";
            this.grpCombat.Size = new System.Drawing.Size(226, 264);
            this.grpCombat.TabIndex = 30;
            this.grpCombat.TabStop = false;
            this.grpCombat.Text = "Combat (Unarmed)";
            // 
            // nudScaling
            // 
            this.nudScaling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudScaling.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudScaling.Location = new System.Drawing.Point(13, 195);
            this.nudScaling.Name = "nudScaling";
            this.nudScaling.Size = new System.Drawing.Size(192, 20);
            this.nudScaling.TabIndex = 61;
            this.nudScaling.ValueChanged += new System.EventHandler(this.nudScaling_ValueChanged);
            // 
            // nudCritChance
            // 
            this.nudCritChance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudCritChance.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudCritChance.Location = new System.Drawing.Point(12, 71);
            this.nudCritChance.Name = "nudCritChance";
            this.nudCritChance.Size = new System.Drawing.Size(192, 20);
            this.nudCritChance.TabIndex = 60;
            this.nudCritChance.ValueChanged += new System.EventHandler(this.nudCritChance_ValueChanged);
            // 
            // nudDamage
            // 
            this.nudDamage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudDamage.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudDamage.Location = new System.Drawing.Point(12, 35);
            this.nudDamage.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDamage.Name = "nudDamage";
            this.nudDamage.Size = new System.Drawing.Size(192, 20);
            this.nudDamage.TabIndex = 59;
            this.nudDamage.ValueChanged += new System.EventHandler(this.nudDamage_ValueChanged);
            // 
            // cmbScalingStat
            // 
            this.cmbScalingStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbScalingStat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbScalingStat.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbScalingStat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbScalingStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScalingStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbScalingStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbScalingStat.FormattingEnabled = true;
            this.cmbScalingStat.Location = new System.Drawing.Point(13, 152);
            this.cmbScalingStat.Name = "cmbScalingStat";
            this.cmbScalingStat.Size = new System.Drawing.Size(191, 21);
            this.cmbScalingStat.TabIndex = 58;
            this.cmbScalingStat.SelectedIndexChanged += new System.EventHandler(this.cmbScalingStat_SelectedIndexChanged);
            // 
            // lblScalingStat
            // 
            this.lblScalingStat.AutoSize = true;
            this.lblScalingStat.Location = new System.Drawing.Point(10, 135);
            this.lblScalingStat.Name = "lblScalingStat";
            this.lblScalingStat.Size = new System.Drawing.Size(67, 13);
            this.lblScalingStat.TabIndex = 57;
            this.lblScalingStat.Text = "Scaling Stat:";
            // 
            // lblScalingAmount
            // 
            this.lblScalingAmount.AutoSize = true;
            this.lblScalingAmount.Location = new System.Drawing.Point(9, 178);
            this.lblScalingAmount.Name = "lblScalingAmount";
            this.lblScalingAmount.Size = new System.Drawing.Size(84, 13);
            this.lblScalingAmount.TabIndex = 56;
            this.lblScalingAmount.Text = "Scaling Amount:";
            // 
            // cmbDamageType
            // 
            this.cmbDamageType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbDamageType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbDamageType.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbDamageType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDamageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDamageType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDamageType.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbDamageType.FormattingEnabled = true;
            this.cmbDamageType.Items.AddRange(new object[] {
            "Physical",
            "Magic",
            "True"});
            this.cmbDamageType.Location = new System.Drawing.Point(13, 111);
            this.cmbDamageType.Name = "cmbDamageType";
            this.cmbDamageType.Size = new System.Drawing.Size(191, 21);
            this.cmbDamageType.TabIndex = 54;
            this.cmbDamageType.SelectedIndexChanged += new System.EventHandler(this.cmbDamageType_SelectedIndexChanged);
            // 
            // lblDamageType
            // 
            this.lblDamageType.AutoSize = true;
            this.lblDamageType.Location = new System.Drawing.Point(10, 94);
            this.lblDamageType.Name = "lblDamageType";
            this.lblDamageType.Size = new System.Drawing.Size(77, 13);
            this.lblDamageType.TabIndex = 53;
            this.lblDamageType.Text = "Damage Type:";
            // 
            // lblCritChance
            // 
            this.lblCritChance.AutoSize = true;
            this.lblCritChance.Location = new System.Drawing.Point(9, 58);
            this.lblCritChance.Name = "lblCritChance";
            this.lblCritChance.Size = new System.Drawing.Size(82, 13);
            this.lblCritChance.TabIndex = 52;
            this.lblCritChance.Text = "Crit Chance: (%)";
            // 
            // cmbAttackAnimation
            // 
            this.cmbAttackAnimation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbAttackAnimation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbAttackAnimation.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbAttackAnimation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAttackAnimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAttackAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAttackAnimation.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbAttackAnimation.FormattingEnabled = true;
            this.cmbAttackAnimation.Location = new System.Drawing.Point(12, 235);
            this.cmbAttackAnimation.Name = "cmbAttackAnimation";
            this.cmbAttackAnimation.Size = new System.Drawing.Size(192, 21);
            this.cmbAttackAnimation.TabIndex = 50;
            this.cmbAttackAnimation.SelectedIndexChanged += new System.EventHandler(this.cmbAttackAnimation_SelectedIndexChanged);
            // 
            // lblAttackAnimation
            // 
            this.lblAttackAnimation.AutoSize = true;
            this.lblAttackAnimation.Location = new System.Drawing.Point(9, 220);
            this.lblAttackAnimation.Name = "lblAttackAnimation";
            this.lblAttackAnimation.Size = new System.Drawing.Size(90, 13);
            this.lblAttackAnimation.TabIndex = 49;
            this.lblAttackAnimation.Text = "Attack Animation:";
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Location = new System.Drawing.Point(9, 18);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(77, 13);
            this.lblDamage.TabIndex = 48;
            this.lblDamage.Text = "Base Damage:";
            // 
            // grpRegen
            // 
            this.grpRegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpRegen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpRegen.Controls.Add(this.nudMpRegen);
            this.grpRegen.Controls.Add(this.nudHPRegen);
            this.grpRegen.Controls.Add(this.lblHpRegen);
            this.grpRegen.Controls.Add(this.lblManaRegen);
            this.grpRegen.Controls.Add(this.lblRegenHint);
            this.grpRegen.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpRegen.Location = new System.Drawing.Point(420, 169);
            this.grpRegen.Margin = new System.Windows.Forms.Padding(2);
            this.grpRegen.Name = "grpRegen";
            this.grpRegen.Padding = new System.Windows.Forms.Padding(2);
            this.grpRegen.Size = new System.Drawing.Size(112, 175);
            this.grpRegen.TabIndex = 19;
            this.grpRegen.TabStop = false;
            this.grpRegen.Text = "Regen";
            // 
            // nudMpRegen
            // 
            this.nudMpRegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMpRegen.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMpRegen.Location = new System.Drawing.Point(8, 69);
            this.nudMpRegen.Name = "nudMpRegen";
            this.nudMpRegen.Size = new System.Drawing.Size(96, 20);
            this.nudMpRegen.TabIndex = 31;
            this.nudMpRegen.ValueChanged += new System.EventHandler(this.nudMpRegen_ValueChanged);
            // 
            // nudHPRegen
            // 
            this.nudHPRegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudHPRegen.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudHPRegen.Location = new System.Drawing.Point(8, 31);
            this.nudHPRegen.Name = "nudHPRegen";
            this.nudHPRegen.Size = new System.Drawing.Size(96, 20);
            this.nudHPRegen.TabIndex = 30;
            this.nudHPRegen.ValueChanged += new System.EventHandler(this.nudHPRegen_ValueChanged);
            // 
            // lblHpRegen
            // 
            this.lblHpRegen.AutoSize = true;
            this.lblHpRegen.Location = new System.Drawing.Point(5, 17);
            this.lblHpRegen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHpRegen.Name = "lblHpRegen";
            this.lblHpRegen.Size = new System.Drawing.Size(42, 13);
            this.lblHpRegen.TabIndex = 26;
            this.lblHpRegen.Text = "HP: (%)";
            // 
            // lblManaRegen
            // 
            this.lblManaRegen.AutoSize = true;
            this.lblManaRegen.Location = new System.Drawing.Point(5, 54);
            this.lblManaRegen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManaRegen.Name = "lblManaRegen";
            this.lblManaRegen.Size = new System.Drawing.Size(54, 13);
            this.lblManaRegen.TabIndex = 27;
            this.lblManaRegen.Text = "Mana: (%)";
            // 
            // lblRegenHint
            // 
            this.lblRegenHint.Location = new System.Drawing.Point(7, 98);
            this.lblRegenHint.Name = "lblRegenHint";
            this.lblRegenHint.Size = new System.Drawing.Size(100, 72);
            this.lblRegenHint.TabIndex = 0;
            this.lblRegenHint.Text = "% of HP/Mana to restore per tick.\r\n\r\nTick timer saved in server config.xml.";
            // 
            // grpLeveling
            // 
            this.grpLeveling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpLeveling.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpLeveling.Controls.Add(this.nudBaseExp);
            this.grpLeveling.Controls.Add(this.nudExpIncrease);
            this.grpLeveling.Controls.Add(this.lblExpIncrease);
            this.grpLeveling.Controls.Add(this.lblBaseExp);
            this.grpLeveling.Controls.Add(this.grpLevelBoosts);
            this.grpLeveling.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpLeveling.Location = new System.Drawing.Point(2, 348);
            this.grpLeveling.Margin = new System.Windows.Forms.Padding(2);
            this.grpLeveling.Name = "grpLeveling";
            this.grpLeveling.Padding = new System.Windows.Forms.Padding(2);
            this.grpLeveling.Size = new System.Drawing.Size(530, 175);
            this.grpLeveling.TabIndex = 29;
            this.grpLeveling.TabStop = false;
            this.grpLeveling.Text = "Leveling Up";
            // 
            // nudBaseExp
            // 
            this.nudBaseExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudBaseExp.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudBaseExp.Location = new System.Drawing.Point(7, 31);
            this.nudBaseExp.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudBaseExp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBaseExp.Name = "nudBaseExp";
            this.nudBaseExp.Size = new System.Drawing.Size(99, 20);
            this.nudBaseExp.TabIndex = 36;
            this.nudBaseExp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBaseExp.ValueChanged += new System.EventHandler(this.nudBaseExp_ValueChanged);
            // 
            // nudExpIncrease
            // 
            this.nudExpIncrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudExpIncrease.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudExpIncrease.Location = new System.Drawing.Point(115, 31);
            this.nudExpIncrease.Name = "nudExpIncrease";
            this.nudExpIncrease.Size = new System.Drawing.Size(122, 20);
            this.nudExpIncrease.TabIndex = 31;
            this.nudExpIncrease.ValueChanged += new System.EventHandler(this.nudExpIncrease_ValueChanged);
            // 
            // lblExpIncrease
            // 
            this.lblExpIncrease.AutoSize = true;
            this.lblExpIncrease.Location = new System.Drawing.Point(112, 15);
            this.lblExpIncrease.Name = "lblExpIncrease";
            this.lblExpIncrease.Size = new System.Drawing.Size(125, 13);
            this.lblExpIncrease.TabIndex = 21;
            this.lblExpIncrease.Text = "Exp Increase (Per Lvl %):";
            // 
            // lblBaseExp
            // 
            this.lblBaseExp.AutoSize = true;
            this.lblBaseExp.Location = new System.Drawing.Point(6, 16);
            this.lblBaseExp.Name = "lblBaseExp";
            this.lblBaseExp.Size = new System.Drawing.Size(100, 13);
            this.lblBaseExp.TabIndex = 19;
            this.lblBaseExp.Text = "Base Exp To Level:";
            // 
            // grpLevelBoosts
            // 
            this.grpLevelBoosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpLevelBoosts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpLevelBoosts.Controls.Add(this.nudHpIncrease);
            this.grpLevelBoosts.Controls.Add(this.nudMpIncrease);
            this.grpLevelBoosts.Controls.Add(this.nudPointsIncrease);
            this.grpLevelBoosts.Controls.Add(this.nudMagicResistIncrease);
            this.grpLevelBoosts.Controls.Add(this.nudSpeedIncrease);
            this.grpLevelBoosts.Controls.Add(this.nudMagicIncrease);
            this.grpLevelBoosts.Controls.Add(this.nudArmorIncrease);
            this.grpLevelBoosts.Controls.Add(this.nudStrengthIncrease);
            this.grpLevelBoosts.Controls.Add(this.rdoPercentageIncrease);
            this.grpLevelBoosts.Controls.Add(this.rdoStaticIncrease);
            this.grpLevelBoosts.Controls.Add(this.lblPointsIncrease);
            this.grpLevelBoosts.Controls.Add(this.lblHpIncrease);
            this.grpLevelBoosts.Controls.Add(this.lblMpIncrease);
            this.grpLevelBoosts.Controls.Add(this.lblSpeedIncrease);
            this.grpLevelBoosts.Controls.Add(this.lblStrengthIncrease);
            this.grpLevelBoosts.Controls.Add(this.lblMagicResistIncrease);
            this.grpLevelBoosts.Controls.Add(this.lblArmorIncrease);
            this.grpLevelBoosts.Controls.Add(this.lblMagicIncrease);
            this.grpLevelBoosts.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpLevelBoosts.Location = new System.Drawing.Point(9, 53);
            this.grpLevelBoosts.Name = "grpLevelBoosts";
            this.grpLevelBoosts.Size = new System.Drawing.Size(429, 116);
            this.grpLevelBoosts.TabIndex = 23;
            this.grpLevelBoosts.TabStop = false;
            this.grpLevelBoosts.Text = "Level Up Boosts";
            // 
            // nudHpIncrease
            // 
            this.nudHpIncrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudHpIncrease.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudHpIncrease.Location = new System.Drawing.Point(11, 47);
            this.nudHpIncrease.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudHpIncrease.Name = "nudHpIncrease";
            this.nudHpIncrease.Size = new System.Drawing.Size(70, 20);
            this.nudHpIncrease.TabIndex = 36;
            this.nudHpIncrease.ValueChanged += new System.EventHandler(this.nudHpIncrease_ValueChanged);
            // 
            // nudMpIncrease
            // 
            this.nudMpIncrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMpIncrease.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMpIncrease.Location = new System.Drawing.Point(111, 47);
            this.nudMpIncrease.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMpIncrease.Name = "nudMpIncrease";
            this.nudMpIncrease.Size = new System.Drawing.Size(70, 20);
            this.nudMpIncrease.TabIndex = 35;
            this.nudMpIncrease.ValueChanged += new System.EventHandler(this.nudMpIncrease_ValueChanged);
            // 
            // nudPointsIncrease
            // 
            this.nudPointsIncrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudPointsIncrease.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudPointsIncrease.Location = new System.Drawing.Point(311, 90);
            this.nudPointsIncrease.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudPointsIncrease.Name = "nudPointsIncrease";
            this.nudPointsIncrease.Size = new System.Drawing.Size(70, 20);
            this.nudPointsIncrease.TabIndex = 34;
            this.nudPointsIncrease.ValueChanged += new System.EventHandler(this.nudPointsIncrease_ValueChanged);
            // 
            // nudMagicResistIncrease
            // 
            this.nudMagicResistIncrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMagicResistIncrease.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMagicResistIncrease.Location = new System.Drawing.Point(311, 47);
            this.nudMagicResistIncrease.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMagicResistIncrease.Name = "nudMagicResistIncrease";
            this.nudMagicResistIncrease.Size = new System.Drawing.Size(70, 20);
            this.nudMagicResistIncrease.TabIndex = 33;
            this.nudMagicResistIncrease.ValueChanged += new System.EventHandler(this.nudMagicResistIncrease_ValueChanged);
            // 
            // nudSpeedIncrease
            // 
            this.nudSpeedIncrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSpeedIncrease.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSpeedIncrease.Location = new System.Drawing.Point(211, 90);
            this.nudSpeedIncrease.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudSpeedIncrease.Name = "nudSpeedIncrease";
            this.nudSpeedIncrease.Size = new System.Drawing.Size(70, 20);
            this.nudSpeedIncrease.TabIndex = 32;
            this.nudSpeedIncrease.ValueChanged += new System.EventHandler(this.nudSpeedIncrease_ValueChanged);
            // 
            // nudMagicIncrease
            // 
            this.nudMagicIncrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudMagicIncrease.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudMagicIncrease.Location = new System.Drawing.Point(111, 90);
            this.nudMagicIncrease.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMagicIncrease.Name = "nudMagicIncrease";
            this.nudMagicIncrease.Size = new System.Drawing.Size(70, 20);
            this.nudMagicIncrease.TabIndex = 31;
            this.nudMagicIncrease.ValueChanged += new System.EventHandler(this.nudMagicIncrease_ValueChanged);
            // 
            // nudArmorIncrease
            // 
            this.nudArmorIncrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudArmorIncrease.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudArmorIncrease.Location = new System.Drawing.Point(211, 47);
            this.nudArmorIncrease.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudArmorIncrease.Name = "nudArmorIncrease";
            this.nudArmorIncrease.Size = new System.Drawing.Size(70, 20);
            this.nudArmorIncrease.TabIndex = 30;
            this.nudArmorIncrease.ValueChanged += new System.EventHandler(this.nudArmorIncrease_ValueChanged);
            // 
            // nudStrengthIncrease
            // 
            this.nudStrengthIncrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudStrengthIncrease.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudStrengthIncrease.Location = new System.Drawing.Point(11, 90);
            this.nudStrengthIncrease.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudStrengthIncrease.Name = "nudStrengthIncrease";
            this.nudStrengthIncrease.Size = new System.Drawing.Size(70, 20);
            this.nudStrengthIncrease.TabIndex = 29;
            this.nudStrengthIncrease.ValueChanged += new System.EventHandler(this.nudStrengthIncrease_ValueChanged);
            // 
            // rdoPercentageIncrease
            // 
            this.rdoPercentageIncrease.AutoSize = true;
            this.rdoPercentageIncrease.Location = new System.Drawing.Point(66, 15);
            this.rdoPercentageIncrease.Name = "rdoPercentageIncrease";
            this.rdoPercentageIncrease.Size = new System.Drawing.Size(80, 17);
            this.rdoPercentageIncrease.TabIndex = 1;
            this.rdoPercentageIncrease.Text = "Percentage";
            this.rdoPercentageIncrease.CheckedChanged += new System.EventHandler(this.rdoPercentageIncrease_CheckedChanged);
            // 
            // rdoStaticIncrease
            // 
            this.rdoStaticIncrease.AutoSize = true;
            this.rdoStaticIncrease.Checked = true;
            this.rdoStaticIncrease.Location = new System.Drawing.Point(7, 15);
            this.rdoStaticIncrease.Name = "rdoStaticIncrease";
            this.rdoStaticIncrease.Size = new System.Drawing.Size(52, 17);
            this.rdoStaticIncrease.TabIndex = 0;
            this.rdoStaticIncrease.TabStop = true;
            this.rdoStaticIncrease.Text = "Static";
            this.rdoStaticIncrease.CheckedChanged += new System.EventHandler(this.rdoStaticIncrease_CheckedChanged);
            // 
            // lblPointsIncrease
            // 
            this.lblPointsIncrease.AutoSize = true;
            this.lblPointsIncrease.Location = new System.Drawing.Point(308, 77);
            this.lblPointsIncrease.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPointsIncrease.Name = "lblPointsIncrease";
            this.lblPointsIncrease.Size = new System.Drawing.Size(39, 13);
            this.lblPointsIncrease.TabIndex = 18;
            this.lblPointsIncrease.Text = "Points:";
            // 
            // lblHpIncrease
            // 
            this.lblHpIncrease.AutoSize = true;
            this.lblHpIncrease.Location = new System.Drawing.Point(8, 31);
            this.lblHpIncrease.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHpIncrease.Name = "lblHpIncrease";
            this.lblHpIncrease.Size = new System.Drawing.Size(48, 13);
            this.lblHpIncrease.TabIndex = 14;
            this.lblHpIncrease.Text = "Max HP:";
            // 
            // lblMpIncrease
            // 
            this.lblMpIncrease.AutoSize = true;
            this.lblMpIncrease.Location = new System.Drawing.Point(111, 31);
            this.lblMpIncrease.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMpIncrease.Name = "lblMpIncrease";
            this.lblMpIncrease.Size = new System.Drawing.Size(49, 13);
            this.lblMpIncrease.TabIndex = 15;
            this.lblMpIncrease.Text = "Max MP:";
            // 
            // lblSpeedIncrease
            // 
            this.lblSpeedIncrease.AutoSize = true;
            this.lblSpeedIncrease.Location = new System.Drawing.Point(208, 77);
            this.lblSpeedIncrease.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpeedIncrease.Name = "lblSpeedIncrease";
            this.lblSpeedIncrease.Size = new System.Drawing.Size(71, 13);
            this.lblSpeedIncrease.TabIndex = 9;
            this.lblSpeedIncrease.Text = "Move Speed:";
            // 
            // lblStrengthIncrease
            // 
            this.lblStrengthIncrease.AutoSize = true;
            this.lblStrengthIncrease.Location = new System.Drawing.Point(8, 77);
            this.lblStrengthIncrease.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStrengthIncrease.Name = "lblStrengthIncrease";
            this.lblStrengthIncrease.Size = new System.Drawing.Size(50, 13);
            this.lblStrengthIncrease.TabIndex = 5;
            this.lblStrengthIncrease.Text = "Strength:";
            // 
            // lblMagicResistIncrease
            // 
            this.lblMagicResistIncrease.AutoSize = true;
            this.lblMagicResistIncrease.Location = new System.Drawing.Point(308, 31);
            this.lblMagicResistIncrease.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMagicResistIncrease.Name = "lblMagicResistIncrease";
            this.lblMagicResistIncrease.Size = new System.Drawing.Size(71, 13);
            this.lblMagicResistIncrease.TabIndex = 8;
            this.lblMagicResistIncrease.Text = "Magic Resist:";
            // 
            // lblArmorIncrease
            // 
            this.lblArmorIncrease.AutoSize = true;
            this.lblArmorIncrease.Location = new System.Drawing.Point(208, 31);
            this.lblArmorIncrease.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArmorIncrease.Name = "lblArmorIncrease";
            this.lblArmorIncrease.Size = new System.Drawing.Size(37, 13);
            this.lblArmorIncrease.TabIndex = 7;
            this.lblArmorIncrease.Text = "Armor:";
            // 
            // lblMagicIncrease
            // 
            this.lblMagicIncrease.AutoSize = true;
            this.lblMagicIncrease.Location = new System.Drawing.Point(108, 77);
            this.lblMagicIncrease.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMagicIncrease.Name = "lblMagicIncrease";
            this.lblMagicIncrease.Size = new System.Drawing.Size(39, 13);
            this.lblMagicIncrease.TabIndex = 6;
            this.lblMagicIncrease.Text = "Magic:";
            // 
            // grpSprite
            // 
            this.grpSprite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpSprite.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpSprite.Controls.Add(this.lblFace);
            this.grpSprite.Controls.Add(this.btnRemove);
            this.grpSprite.Controls.Add(this.picFace);
            this.grpSprite.Controls.Add(this.lblSpriteOptions);
            this.grpSprite.Controls.Add(this.cmbFace);
            this.grpSprite.Controls.Add(this.btnAdd);
            this.grpSprite.Controls.Add(this.grpGender);
            this.grpSprite.Controls.Add(this.lstSprites);
            this.grpSprite.Controls.Add(this.lblSprite);
            this.grpSprite.Controls.Add(this.picSprite);
            this.grpSprite.Controls.Add(this.cmbSprite);
            this.grpSprite.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpSprite.Location = new System.Drawing.Point(256, 0);
            this.grpSprite.Name = "grpSprite";
            this.grpSprite.Size = new System.Drawing.Size(384, 163);
            this.grpSprite.TabIndex = 28;
            this.grpSprite.TabStop = false;
            this.grpSprite.Text = "Sprite and Face";
            // 
            // lblFace
            // 
            this.lblFace.AutoSize = true;
            this.lblFace.Location = new System.Drawing.Point(222, 76);
            this.lblFace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFace.Name = "lblFace";
            this.lblFace.Size = new System.Drawing.Size(34, 13);
            this.lblFace.TabIndex = 22;
            this.lblFace.Text = "Face:";
            // 
            // picFace
            // 
            this.picFace.BackColor = System.Drawing.Color.Black;
            this.picFace.Location = new System.Drawing.Point(225, 89);
            this.picFace.Margin = new System.Windows.Forms.Padding(2);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(64, 64);
            this.picFace.TabIndex = 21;
            this.picFace.TabStop = false;
            // 
            // lblSpriteOptions
            // 
            this.lblSpriteOptions.AutoSize = true;
            this.lblSpriteOptions.Location = new System.Drawing.Point(6, 17);
            this.lblSpriteOptions.Name = "lblSpriteOptions";
            this.lblSpriteOptions.Size = new System.Drawing.Size(46, 13);
            this.lblSpriteOptions.TabIndex = 18;
            this.lblSpriteOptions.Text = "Options:";
            // 
            // cmbFace
            // 
            this.cmbFace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbFace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbFace.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbFace.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFace.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbFace.FormattingEnabled = true;
            this.cmbFace.Items.AddRange(new object[] {
            Strings.Get("general","none")});
            this.cmbFace.Location = new System.Drawing.Point(293, 89);
            this.cmbFace.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFace.Name = "cmbFace";
            this.cmbFace.Size = new System.Drawing.Size(83, 21);
            this.cmbFace.TabIndex = 23;
            this.cmbFace.SelectedIndexChanged += new System.EventHandler(this.cmbFace_SelectedIndexChanged);
            // 
            // grpGender
            // 
            this.grpGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpGender.Controls.Add(this.rbMale);
            this.grpGender.Controls.Add(this.rbFemale);
            this.grpGender.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpGender.Location = new System.Drawing.Point(153, 16);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(64, 75);
            this.grpGender.TabIndex = 20;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(800, 400);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(127, 32);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(669, 400);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(127, 32);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemNew,
            this.toolStripSeparator1,
            this.toolStripItemDelete,
            this.toolStripSeparator2,
            this.toolStripItemCopy,
            this.toolStripItemPaste,
            this.toolStripSeparator3,
            this.toolStripItemUndo});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.toolStrip.Size = new System.Drawing.Size(929, 25);
            this.toolStrip.TabIndex = 42;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripItemNew
            // 
            this.toolStripItemNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemNew.Image")));
            this.toolStripItemNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemNew.Name = "toolStripItemNew";
            this.toolStripItemNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemNew.Text = "New";
            this.toolStripItemNew.Click += new System.EventHandler(this.toolStripItemNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripItemDelete
            // 
            this.toolStripItemDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemDelete.Enabled = false;
            this.toolStripItemDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemDelete.Image")));
            this.toolStripItemDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemDelete.Name = "toolStripItemDelete";
            this.toolStripItemDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemDelete.Text = "Delete";
            this.toolStripItemDelete.Click += new System.EventHandler(this.toolStripItemDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripItemCopy
            // 
            this.toolStripItemCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemCopy.Enabled = false;
            this.toolStripItemCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemCopy.Image")));
            this.toolStripItemCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemCopy.Name = "toolStripItemCopy";
            this.toolStripItemCopy.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemCopy.Text = "Copy";
            this.toolStripItemCopy.Click += new System.EventHandler(this.toolStripItemCopy_Click);
            // 
            // toolStripItemPaste
            // 
            this.toolStripItemPaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStripItemPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemPaste.Enabled = false;
            this.toolStripItemPaste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemPaste.Image")));
            this.toolStripItemPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemPaste.Name = "toolStripItemPaste";
            this.toolStripItemPaste.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemPaste.Text = "Paste";
            this.toolStripItemPaste.Click += new System.EventHandler(this.toolStripItemPaste_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripItemUndo
            // 
            this.toolStripItemUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemUndo.Enabled = false;
            this.toolStripItemUndo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemUndo.Image")));
            this.toolStripItemUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemUndo.Name = "toolStripItemUndo";
            this.toolStripItemUndo.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemUndo.Text = "Undo";
            this.toolStripItemUndo.Click += new System.EventHandler(this.toolStripItemUndo_Click);
            // 
            // frmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(929, 437);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpClasses);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmClass";
            this.Text = "Class Editor";
            this.Load += new System.EventHandler(this.frmClass_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
            this.grpClasses.ResumeLayout(false);
            this.grpItems.ResumeLayout(false);
            this.grpItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemAmount)).EndInit();
            this.grpBaseStats.ResumeLayout(false);
            this.grpBaseStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaseMana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaseHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttack)).EndInit();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSprite)).EndInit();
            this.grpSpells.ResumeLayout(false);
            this.grpSpells.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            this.grpSpawnPoint.ResumeLayout(false);
            this.grpSpawnPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.grpCombat.ResumeLayout(false);
            this.grpCombat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCritChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDamage)).EndInit();
            this.grpRegen.ResumeLayout(false);
            this.grpRegen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMpRegen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHPRegen)).EndInit();
            this.grpLeveling.ResumeLayout(false);
            this.grpLeveling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaseExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpIncrease)).EndInit();
            this.grpLevelBoosts.ResumeLayout(false);
            this.grpLevelBoosts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHpIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMpIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointsIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagicResistIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeedIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMagicIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArmorIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrengthIncrease)).EndInit();
            this.grpSprite.ResumeLayout(false);
            this.grpSprite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkGroupBox grpClasses;
        private System.Windows.Forms.ListBox lstClasses;
        private DarkGroupBox grpItems;
        private System.Windows.Forms.Label lblDropAmount;
        private System.Windows.Forms.Label lblDropItem;
        private DarkScrollBar scrlDropIndex;
        private System.Windows.Forms.Label lblDropIndex;
        private DarkGroupBox grpBaseStats;
        private System.Windows.Forms.Label lblMana;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblSpd;
        private System.Windows.Forms.Label lblMR;
        private System.Windows.Forms.Label lblDef;
        private System.Windows.Forms.Label lblMag;
        private System.Windows.Forms.Label lblAttack;
        private DarkGroupBox grpGeneral;
        private System.Windows.Forms.ListBox lstSprites;
        private DarkComboBox cmbSprite;
        private System.Windows.Forms.Label lblSprite;
        private System.Windows.Forms.PictureBox picSprite;
        private System.Windows.Forms.Label lblName;
        private DarkTextBox txtName;
        private DarkButton btnRemove;
        private DarkButton btnAdd;
        private DarkRadioButton rbFemale;
        private DarkRadioButton rbMale;
        private DarkGroupBox grpSpells;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblSpellNum;
        private DarkButton btnRemoveSpell;
        private DarkButton btnAddSpell;
        private System.Windows.Forms.ListBox lstSpells;
        private System.Windows.Forms.Label lblPoints;
        private DarkGroupBox grpSpawnPoint;
        private DarkButton btnVisualMapSelector;
        private DarkComboBox cmbWarpMap;
        private DarkComboBox cmbDirection;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Panel pnlContainer;
        private DarkButton btnSave;
        private DarkButton btnCancel;
        private DarkGroupBox grpSprite;
        private System.Windows.Forms.Label lblFace;
        private System.Windows.Forms.PictureBox picFace;
        private DarkComboBox cmbFace;
        private DarkGroupBox grpGender;
        private System.Windows.Forms.Label lblSpriteOptions;
        private DarkCheckBox chkLocked;
        private DarkGroupBox grpRegen;
        private System.Windows.Forms.Label lblHpRegen;
        private System.Windows.Forms.Label lblManaRegen;
        private System.Windows.Forms.Label lblRegenHint;
        private DarkGroupBox grpLeveling;
        private System.Windows.Forms.Label lblExpIncrease;
        private System.Windows.Forms.Label lblBaseExp;
        private DarkGroupBox grpLevelBoosts;
        private DarkRadioButton rdoPercentageIncrease;
        private DarkRadioButton rdoStaticIncrease;
        private System.Windows.Forms.Label lblPointsIncrease;
        private System.Windows.Forms.Label lblHpIncrease;
        private System.Windows.Forms.Label lblMpIncrease;
        private System.Windows.Forms.Label lblSpeedIncrease;
        private System.Windows.Forms.Label lblStrengthIncrease;
        private System.Windows.Forms.Label lblMagicResistIncrease;
        private System.Windows.Forms.Label lblArmorIncrease;
        private System.Windows.Forms.Label lblMagicIncrease;
        private DarkToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripItemNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton toolStripItemCopy;
        public System.Windows.Forms.ToolStripButton toolStripItemPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton toolStripItemUndo;
        private DarkGroupBox grpCombat;
        private DarkComboBox cmbScalingStat;
        private System.Windows.Forms.Label lblScalingStat;
        private System.Windows.Forms.Label lblScalingAmount;
        private DarkComboBox cmbDamageType;
        private System.Windows.Forms.Label lblDamageType;
        private System.Windows.Forms.Label lblCritChance;
        private DarkComboBox cmbAttackAnimation;
        private System.Windows.Forms.Label lblAttackAnimation;
        private System.Windows.Forms.Label lblDamage;
        private DarkComboBox cmbItem;
        private DarkComboBox cmbSpell;
        private DarkNumericUpDown nudLevel;
        private DarkNumericUpDown nudY;
        private DarkNumericUpDown nudX;
        private DarkNumericUpDown nudScaling;
        private DarkNumericUpDown nudCritChance;
        private DarkNumericUpDown nudDamage;
        private DarkNumericUpDown nudMpRegen;
        private DarkNumericUpDown nudHPRegen;
        private DarkNumericUpDown nudPoints;
        private DarkNumericUpDown nudSpd;
        private DarkNumericUpDown nudMR;
        private DarkNumericUpDown nudDef;
        private DarkNumericUpDown nudMag;
        private DarkNumericUpDown nudAttack;
        private DarkNumericUpDown nudExpIncrease;
        private DarkNumericUpDown nudHpIncrease;
        private DarkNumericUpDown nudMpIncrease;
        private DarkNumericUpDown nudPointsIncrease;
        private DarkNumericUpDown nudMagicResistIncrease;
        private DarkNumericUpDown nudSpeedIncrease;
        private DarkNumericUpDown nudMagicIncrease;
        private DarkNumericUpDown nudArmorIncrease;
        private DarkNumericUpDown nudStrengthIncrease;
        private DarkNumericUpDown nudItemAmount;
        private DarkNumericUpDown nudBaseMana;
        private DarkNumericUpDown nudBaseHP;
        private DarkNumericUpDown nudBaseExp;
    }
}