﻿namespace JsonGenerator.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            GeneralMenuItem = new ToolStripMenuItem();
            ConfigMenuItem = new ToolStripMenuItem();
            AboutToolStripMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            comboBoxTemplateNames = new ComboBox();
            label1 = new Label();
            tabControl = new TabControl();
            tabPageGeneral = new TabPage();
            richTextBoxJsonSchem = new RichTextBox();
            richTextBoxJsonExample = new RichTextBox();
            btnGeneretSchema = new Button();
            btnGeneretExample = new Button();
            tabPageConfig = new TabPage();
            btnUpdateClasses = new Button();
            btnSaveClass = new Button();
            labelClassPath = new Label();
            labelAddClassTitle = new Label();
            progressBarClassCopy = new ProgressBar();
            btnAddNewClass = new Button();
            btnInsertDefoultClasses = new Button();
            btnSetDefultConfigs = new Button();
            btnDeleteAllConfig = new Button();
            SaveSchemaFolderName = new Button();
            SaveJsonFolderName = new Button();
            textBoxSchemaName = new TextBox();
            textBoxJsonName = new TextBox();
            textBoxBaseFolderName = new TextBox();
            labelJsonSchemaFolder = new Label();
            label6 = new Label();
            label4 = new Label();
            SaveBaseFolderName = new Button();
            saveBaseDirectory = new Button();
            textBoxBaseDirectory = new TextBox();
            label2 = new Label();
            bindingSource1 = new BindingSource(components);
            progressBarUpdate = new ProgressBar();
            menuStrip.SuspendLayout();
            tabControl.SuspendLayout();
            tabPageGeneral.SuspendLayout();
            tabPageConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1741, 28);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "Մենյու";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { GeneralMenuItem, ConfigMenuItem, AboutToolStripMenuItem, ExitMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(69, 24);
            menuToolStripMenuItem.Text = "Մենյու";
            // 
            // GeneralMenuItem
            // 
            GeneralMenuItem.Name = "GeneralMenuItem";
            GeneralMenuItem.Size = new Size(218, 26);
            GeneralMenuItem.Text = "Գլխավոր";
            GeneralMenuItem.Click += GeneralMenuItem_Click;
            // 
            // ConfigMenuItem
            // 
            ConfigMenuItem.Name = "ConfigMenuItem";
            ConfigMenuItem.Size = new Size(218, 26);
            ConfigMenuItem.Text = "Կարգավորումներ";
            ConfigMenuItem.Click += ConfigMenuItem_Click;
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            AboutToolStripMenuItem.Size = new Size(218, 26);
            AboutToolStripMenuItem.Text = "Ծրագրի մասին";
            AboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(218, 26);
            ExitMenuItem.Text = "Ելք";
            ExitMenuItem.Click += ExitMenuItem_Click;
            // 
            // comboBoxTemplateNames
            // 
            comboBoxTemplateNames.FormattingEnabled = true;
            comboBoxTemplateNames.Location = new Point(732, 33);
            comboBoxTemplateNames.Name = "comboBoxTemplateNames";
            comboBoxTemplateNames.Size = new Size(514, 28);
            comboBoxTemplateNames.TabIndex = 2;
            comboBoxTemplateNames.SelectedValueChanged += comboBoxTemplateNames_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(506, 33);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 0;
            label1.Text = "Ընտրք Class-ի անունը";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageGeneral);
            tabControl.Controls.Add(tabPageConfig);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 28);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1741, 870);
            tabControl.TabIndex = 3;
            // 
            // tabPageGeneral
            // 
            tabPageGeneral.Controls.Add(richTextBoxJsonSchem);
            tabPageGeneral.Controls.Add(richTextBoxJsonExample);
            tabPageGeneral.Controls.Add(btnGeneretSchema);
            tabPageGeneral.Controls.Add(btnGeneretExample);
            tabPageGeneral.Controls.Add(label1);
            tabPageGeneral.Controls.Add(comboBoxTemplateNames);
            tabPageGeneral.Location = new Point(4, 29);
            tabPageGeneral.Name = "tabPageGeneral";
            tabPageGeneral.Padding = new Padding(3);
            tabPageGeneral.Size = new Size(1733, 837);
            tabPageGeneral.TabIndex = 0;
            tabPageGeneral.Text = "Գլխավոր";
            tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // richTextBoxJsonSchem
            // 
            richTextBoxJsonSchem.Location = new Point(938, 167);
            richTextBoxJsonSchem.Name = "richTextBoxJsonSchem";
            richTextBoxJsonSchem.Size = new Size(749, 638);
            richTextBoxJsonSchem.TabIndex = 5;
            richTextBoxJsonSchem.Text = "";
            richTextBoxJsonSchem.Visible = false;
            // 
            // richTextBoxJsonExample
            // 
            richTextBoxJsonExample.Location = new Point(51, 167);
            richTextBoxJsonExample.Name = "richTextBoxJsonExample";
            richTextBoxJsonExample.Size = new Size(749, 638);
            richTextBoxJsonExample.TabIndex = 4;
            richTextBoxJsonExample.Text = "";
            richTextBoxJsonExample.Visible = false;
            // 
            // btnGeneretSchema
            // 
            btnGeneretSchema.Enabled = false;
            btnGeneretSchema.Location = new Point(1191, 96);
            btnGeneretSchema.Name = "btnGeneretSchema";
            btnGeneretSchema.Size = new Size(238, 29);
            btnGeneretSchema.TabIndex = 3;
            btnGeneretSchema.Text = "Գեներացնել Json Schema";
            btnGeneretSchema.UseVisualStyleBackColor = true;
            btnGeneretSchema.Click += btnGeneretSchema_Click;
            // 
            // btnGeneretExample
            // 
            btnGeneretExample.Enabled = false;
            btnGeneretExample.Location = new Point(277, 96);
            btnGeneretExample.Name = "btnGeneretExample";
            btnGeneretExample.Size = new Size(238, 29);
            btnGeneretExample.TabIndex = 2;
            btnGeneretExample.Text = "Գեներացնել Json Example";
            btnGeneretExample.UseVisualStyleBackColor = true;
            btnGeneretExample.Click += btnGeneretExample_Click;
            // 
            // tabPageConfig
            // 
            tabPageConfig.Controls.Add(progressBarUpdate);
            tabPageConfig.Controls.Add(btnUpdateClasses);
            tabPageConfig.Controls.Add(btnSaveClass);
            tabPageConfig.Controls.Add(labelClassPath);
            tabPageConfig.Controls.Add(labelAddClassTitle);
            tabPageConfig.Controls.Add(progressBarClassCopy);
            tabPageConfig.Controls.Add(btnAddNewClass);
            tabPageConfig.Controls.Add(btnInsertDefoultClasses);
            tabPageConfig.Controls.Add(btnSetDefultConfigs);
            tabPageConfig.Controls.Add(btnDeleteAllConfig);
            tabPageConfig.Controls.Add(SaveSchemaFolderName);
            tabPageConfig.Controls.Add(SaveJsonFolderName);
            tabPageConfig.Controls.Add(textBoxSchemaName);
            tabPageConfig.Controls.Add(textBoxJsonName);
            tabPageConfig.Controls.Add(textBoxBaseFolderName);
            tabPageConfig.Controls.Add(labelJsonSchemaFolder);
            tabPageConfig.Controls.Add(label6);
            tabPageConfig.Controls.Add(label4);
            tabPageConfig.Controls.Add(SaveBaseFolderName);
            tabPageConfig.Controls.Add(saveBaseDirectory);
            tabPageConfig.Controls.Add(textBoxBaseDirectory);
            tabPageConfig.Controls.Add(label2);
            tabPageConfig.Location = new Point(4, 29);
            tabPageConfig.Name = "tabPageConfig";
            tabPageConfig.Padding = new Padding(3);
            tabPageConfig.Size = new Size(1733, 837);
            tabPageConfig.TabIndex = 1;
            tabPageConfig.Text = "Կարգավորումներ";
            tabPageConfig.UseVisualStyleBackColor = true;
            // 
            // btnUpdateClasses
            // 
            btnUpdateClasses.BackColor = Color.DeepSkyBlue;
            btnUpdateClasses.Location = new Point(984, 233);
            btnUpdateClasses.Name = "btnUpdateClasses";
            btnUpdateClasses.Size = new Size(294, 59);
            btnUpdateClasses.TabIndex = 23;
            btnUpdateClasses.Text = "Թարմացնել Class-ները";
            btnUpdateClasses.UseVisualStyleBackColor = false;
            // 
            // btnSaveClass
            // 
            btnSaveClass.BackColor = Color.Transparent;
            btnSaveClass.Enabled = false;
            btnSaveClass.Location = new Point(654, 453);
            btnSaveClass.Name = "btnSaveClass";
            btnSaveClass.Size = new Size(248, 59);
            btnSaveClass.TabIndex = 22;
            btnSaveClass.Text = "Պահպանել Class-ի ֆայլը";
            btnSaveClass.UseVisualStyleBackColor = false;
            btnSaveClass.Click += btnSaveClass_Click;
            // 
            // labelClassPath
            // 
            labelClassPath.AutoSize = true;
            labelClassPath.Location = new Point(326, 534);
            labelClassPath.Name = "labelClassPath";
            labelClassPath.Size = new Size(0, 20);
            labelClassPath.TabIndex = 21;
            // 
            // labelAddClassTitle
            // 
            labelAddClassTitle.AutoSize = true;
            labelAddClassTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddClassTitle.Location = new Point(637, 388);
            labelAddClassTitle.Name = "labelAddClassTitle";
            labelAddClassTitle.Size = new Size(288, 38);
            labelAddClassTitle.TabIndex = 20;
            labelAddClassTitle.Text = "Ավելացնել նոր Class";
            // 
            // progressBarClassCopy
            // 
            progressBarClassCopy.Location = new Point(326, 587);
            progressBarClassCopy.MarqueeAnimationSpeed = 30;
            progressBarClassCopy.Name = "progressBarClassCopy";
            progressBarClassCopy.Size = new Size(886, 29);
            progressBarClassCopy.Step = 50;
            progressBarClassCopy.Style = ProgressBarStyle.Marquee;
            progressBarClassCopy.TabIndex = 10;
            progressBarClassCopy.Visible = false;
            // 
            // btnAddNewClass
            // 
            btnAddNewClass.BackColor = Color.LightCyan;
            btnAddNewClass.Location = new Point(326, 453);
            btnAddNewClass.Name = "btnAddNewClass";
            btnAddNewClass.Size = new Size(248, 59);
            btnAddNewClass.TabIndex = 19;
            btnAddNewClass.Text = "Կցել նոր Class";
            btnAddNewClass.UseVisualStyleBackColor = false;
            btnAddNewClass.Click += btnAddNewClass_Click;
            // 
            // btnInsertDefoultClasses
            // 
            btnInsertDefoultClasses.BackColor = Color.Transparent;
            btnInsertDefoultClasses.Enabled = false;
            btnInsertDefoultClasses.Location = new Point(964, 453);
            btnInsertDefoultClasses.Name = "btnInsertDefoultClasses";
            btnInsertDefoultClasses.Size = new Size(248, 59);
            btnInsertDefoultClasses.TabIndex = 18;
            btnInsertDefoultClasses.Text = "Թարմացնել Class-ների ցուցակը";
            btnInsertDefoultClasses.UseVisualStyleBackColor = false;
            btnInsertDefoultClasses.Click += btnInsertDefoultClasses_Click;
            // 
            // btnSetDefultConfigs
            // 
            btnSetDefultConfigs.BackColor = Color.LawnGreen;
            btnSetDefultConfigs.Location = new Point(326, 232);
            btnSetDefultConfigs.Name = "btnSetDefultConfigs";
            btnSetDefultConfigs.Size = new Size(307, 59);
            btnSetDefultConfigs.TabIndex = 17;
            btnSetDefultConfigs.Text = "Տեղադրել ստանդարտ կարգավորումներ";
            btnSetDefultConfigs.UseVisualStyleBackColor = false;
            btnSetDefultConfigs.Click += btnSetDefultConfigs_Click;
            // 
            // btnDeleteAllConfig
            // 
            btnDeleteAllConfig.BackColor = Color.Red;
            btnDeleteAllConfig.Location = new Point(665, 233);
            btnDeleteAllConfig.Name = "btnDeleteAllConfig";
            btnDeleteAllConfig.Size = new Size(294, 59);
            btnDeleteAllConfig.TabIndex = 16;
            btnDeleteAllConfig.Text = "Ջնջել բոլոր կարգավորումները";
            btnDeleteAllConfig.UseVisualStyleBackColor = false;
            btnDeleteAllConfig.Click += btnDeleteAllConfig_Click;
            // 
            // SaveSchemaFolderName
            // 
            SaveSchemaFolderName.Enabled = false;
            SaveSchemaFolderName.Location = new Point(1227, 160);
            SaveSchemaFolderName.Name = "SaveSchemaFolderName";
            SaveSchemaFolderName.Size = new Size(127, 29);
            SaveSchemaFolderName.TabIndex = 15;
            SaveSchemaFolderName.Text = "Պահպանել";
            SaveSchemaFolderName.UseVisualStyleBackColor = true;
            SaveSchemaFolderName.Click += SaveSchemaFolderName_Click;
            // 
            // SaveJsonFolderName
            // 
            SaveJsonFolderName.Enabled = false;
            SaveJsonFolderName.Location = new Point(1227, 119);
            SaveJsonFolderName.Name = "SaveJsonFolderName";
            SaveJsonFolderName.Size = new Size(127, 29);
            SaveJsonFolderName.TabIndex = 14;
            SaveJsonFolderName.Text = "Պահպանել";
            SaveJsonFolderName.UseVisualStyleBackColor = true;
            SaveJsonFolderName.Click += SaveJsonFolderName_Click;
            // 
            // textBoxSchemaName
            // 
            textBoxSchemaName.Location = new Point(326, 157);
            textBoxSchemaName.Name = "textBoxSchemaName";
            textBoxSchemaName.Size = new Size(886, 27);
            textBoxSchemaName.TabIndex = 12;
            textBoxSchemaName.KeyPress += textBoxSchemaName_KeyPress;
            // 
            // textBoxJsonName
            // 
            textBoxJsonName.Location = new Point(326, 119);
            textBoxJsonName.Name = "textBoxJsonName";
            textBoxJsonName.Size = new Size(886, 27);
            textBoxJsonName.TabIndex = 11;
            textBoxJsonName.KeyPress += textBoxJsonName_KeyPress;
            // 
            // textBoxBaseFolderName
            // 
            textBoxBaseFolderName.Location = new Point(326, 74);
            textBoxBaseFolderName.Name = "textBoxBaseFolderName";
            textBoxBaseFolderName.Size = new Size(886, 27);
            textBoxBaseFolderName.TabIndex = 9;
            textBoxBaseFolderName.KeyPress += textBoxBaseFolderName_KeyPress;
            // 
            // labelJsonSchemaFolder
            // 
            labelJsonSchemaFolder.AutoSize = true;
            labelJsonSchemaFolder.Location = new Point(43, 160);
            labelJsonSchemaFolder.Name = "labelJsonSchemaFolder";
            labelJsonSchemaFolder.Size = new Size(280, 20);
            labelJsonSchemaFolder.TabIndex = 7;
            labelJsonSchemaFolder.Text = "Json Schema-ների Folder-ի անվանումը";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 119);
            label6.Name = "label6";
            label6.Size = new Size(285, 20);
            label6.TabIndex = 6;
            label6.Text = "Json Example-ների Folder-ի անվանումը";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 74);
            label4.Name = "label4";
            label4.Size = new Size(188, 20);
            label4.TabIndex = 4;
            label4.Text = "Base Folder-ի անվանումը";
            // 
            // SaveBaseFolderName
            // 
            SaveBaseFolderName.Enabled = false;
            SaveBaseFolderName.Location = new Point(1227, 74);
            SaveBaseFolderName.Name = "SaveBaseFolderName";
            SaveBaseFolderName.Size = new Size(127, 29);
            SaveBaseFolderName.TabIndex = 3;
            SaveBaseFolderName.Text = "Պահպանել";
            SaveBaseFolderName.UseVisualStyleBackColor = true;
            SaveBaseFolderName.Click += SaveBaseFolderName_Click;
            // 
            // saveBaseDirectory
            // 
            saveBaseDirectory.Enabled = false;
            saveBaseDirectory.Location = new Point(1227, 30);
            saveBaseDirectory.Name = "saveBaseDirectory";
            saveBaseDirectory.Size = new Size(127, 27);
            saveBaseDirectory.TabIndex = 2;
            saveBaseDirectory.Text = "Պահպանել";
            saveBaseDirectory.UseVisualStyleBackColor = true;
            saveBaseDirectory.Click += saveBaseDirectory_Click;
            // 
            // textBoxBaseDirectory
            // 
            textBoxBaseDirectory.Location = new Point(326, 30);
            textBoxBaseDirectory.Name = "textBoxBaseDirectory";
            textBoxBaseDirectory.Size = new Size(886, 27);
            textBoxBaseDirectory.TabIndex = 1;
            textBoxBaseDirectory.KeyPress += textBoxBaseDirectory_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 30);
            label2.Name = "label2";
            label2.Size = new Size(240, 20);
            label2.TabIndex = 0;
            label2.Text = "Գլխավոր directory-ի անվանումը";
            // 
            // progressBarUpdate
            // 
            progressBarUpdate.Location = new Point(335, 336);
            progressBarUpdate.MarqueeAnimationSpeed = 30;
            progressBarUpdate.Name = "progressBarUpdate";
            progressBarUpdate.Size = new Size(886, 29);
            progressBarUpdate.Step = 50;
            progressBarUpdate.Style = ProgressBarStyle.Marquee;
            progressBarUpdate.TabIndex = 24;
            progressBarUpdate.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1741, 898);
            Controls.Add(tabControl);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Json Generator";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPageGeneral.ResumeLayout(false);
            tabPageGeneral.PerformLayout();
            tabPageConfig.ResumeLayout(false);
            tabPageConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem ConfigMenuItem;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem GeneralMenuItem;
        private ComboBox comboBoxTemplateNames;
        private Label label1;
        private TabControl tabControl;
        private TabPage tabPageGeneral;
        private TabPage tabPageConfig;
        private Label label2;
        private ToolStripMenuItem AboutToolStripMenuItem;
        private TextBox textBoxBaseDirectory;
        private Button saveBaseDirectory;
        private Label label6;
        private Label label4;
        private Button SaveBaseFolderName;
        private BindingSource bindingSource1;
        private Label labelJsonSchemaFolder;
        private Button SaveSchemaFolderName;
        private Button SaveJsonFolderName;
        private TextBox textBoxSchemaName;
        private TextBox textBoxJsonName;
        private TextBox textBoxBaseFolderName;
        private Button btnGeneretExample;
        private Button btnGeneretSchema;
        private RichTextBox richTextBoxJsonExample;
        private RichTextBox richTextBoxJsonSchem;
        private Button btnSetDefultConfigs;
        private Button btnDeleteAllConfig;
        private Button btnInsertDefoultClasses;
        private Button btnAddNewClass;
        private ProgressBar progressBarClassCopy;
        private Label labelAddClassTitle;
        private Label labelClassPath;
        private Button btnSaveClass;
        private Button btnUpdateClasses;
        private ProgressBar progressBarUpdate;
    }
}
