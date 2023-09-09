namespace TaroStudio
{
    partial class TaroStudio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaroStudio));
            toolStripTop = new ToolStrip();
            contextMenu_Card = new ContextMenuStrip(components);
            cardMenuItem_Change = new ToolStripMenuItem();
            cardMenuItem_Delete = new ToolStripMenuItem();
            cardMenuItem_Reverse = new ToolStripMenuItem();
            cardMenuItem_Rotate = new ToolStripMenuItem();
            toolStripMenu_File = new ToolStripDropDownButton();
            toolStripItem_New = new ToolStripMenuItem();
            toolStripItem_Open = new ToolStripMenuItem();
            toolStripItem_Save = new ToolStripMenuItem();
            toolStripItem_SaveAs = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripItem_Setting = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripItem_Exit = new ToolStripMenuItem();
            toolStripMenu_Edit = new ToolStripDropDownButton();
            toolStripItem_Undo = new ToolStripMenuItem();
            toolStripItem_Redo = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripItem_Cut = new ToolStripMenuItem();
            toolStripItem_Copy = new ToolStripMenuItem();
            toolStripItem_Paste = new ToolStripMenuItem();
            toolStripItem_Del = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripItem_AllSelect = new ToolStripMenuItem();
            toolStripMenu_Capture = new ToolStripDropDownButton();
            toolStripItem_CaptToggle = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            toolStripItem_CaptChange = new ToolStripMenuItem();
            toolStripItem_CaptAll = new ToolStripMenuItem();
            toolStripItem_CaptSingle = new ToolStripMenuItem();
            contextMenu_Empty = new ContextMenuStrip(components);
            emptyMenuItem__Add = new ToolStripMenuItem();
            emptyMenuItem_CardAdd = new ToolStripMenuItem();
            emptyMenuItem_TextAdd = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            emptyMenuItem_Paste = new ToolStripMenuItem();
            emptyMenuItem_AllSelect = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            emptyMenuItem_Undo = new ToolStripMenuItem();
            emptyMenuItem_Redo = new ToolStripMenuItem();
            contextMenu_Text = new ContextMenuStrip(components);
            textMenuItem_Change = new ToolStripMenuItem();
            textMenuItem_Delete = new ToolStripMenuItem();
            textMenuItem_Rotate = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            서식WToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            새로만들기NToolStripButton = new ToolStripButton();
            열기OToolStripButton = new ToolStripButton();
            저장SToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            잘라내기UToolStripButton = new ToolStripButton();
            복사CToolStripButton = new ToolStripButton();
            붙여넣기PToolStripButton = new ToolStripButton();
            toolStripSeparator9 = new ToolStripSeparator();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripButton1 = new ToolStripButton();
            toolStripTop.SuspendLayout();
            contextMenu_Card.SuspendLayout();
            contextMenu_Empty.SuspendLayout();
            contextMenu_Text.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripTop
            // 
            toolStripTop.ContextMenuStrip = contextMenu_Card;
            toolStripTop.GripStyle = ToolStripGripStyle.Hidden;
            toolStripTop.Items.AddRange(new ToolStripItem[] { toolStripMenu_File, toolStripMenu_Edit, toolStripMenu_Capture });
            toolStripTop.Location = new Point(0, 0);
            toolStripTop.Name = "toolStripTop";
            toolStripTop.ShowItemToolTips = false;
            toolStripTop.Size = new Size(1077, 25);
            toolStripTop.TabIndex = 0;
            toolStripTop.Text = "toolStrip1";
            // 
            // contextMenu_Card
            // 
            contextMenu_Card.Items.AddRange(new ToolStripItem[] { cardMenuItem_Change, cardMenuItem_Delete, cardMenuItem_Reverse, cardMenuItem_Rotate });
            contextMenu_Card.Name = "ContextMenu_Card";
            contextMenu_Card.Size = new Size(153, 92);
            // 
            // cardMenuItem_Change
            // 
            cardMenuItem_Change.Name = "cardMenuItem_Change";
            cardMenuItem_Change.Size = new Size(152, 22);
            cardMenuItem_Change.Text = "카드 변경(&C)";
            // 
            // cardMenuItem_Delete
            // 
            cardMenuItem_Delete.Name = "cardMenuItem_Delete";
            cardMenuItem_Delete.Size = new Size(152, 22);
            cardMenuItem_Delete.Text = "카드 삭제(&D)";
            // 
            // cardMenuItem_Reverse
            // 
            cardMenuItem_Reverse.Name = "cardMenuItem_Reverse";
            cardMenuItem_Reverse.Size = new Size(152, 22);
            cardMenuItem_Reverse.Text = "카드 뒤집기(&T)";
            // 
            // cardMenuItem_Rotate
            // 
            cardMenuItem_Rotate.Name = "cardMenuItem_Rotate";
            cardMenuItem_Rotate.Size = new Size(152, 22);
            cardMenuItem_Rotate.Text = "카드 회전(&R)";
            // 
            // toolStripMenu_File
            // 
            toolStripMenu_File.AutoSize = false;
            toolStripMenu_File.AutoToolTip = false;
            toolStripMenu_File.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenu_File.DropDownItems.AddRange(new ToolStripItem[] { toolStripItem_New, toolStripItem_Open, toolStripItem_Save, toolStripItem_SaveAs, toolStripSeparator2, toolStripItem_Setting, toolStripSeparator1, toolStripItem_Exit });
            toolStripMenu_File.Image = (Image)resources.GetObject("toolStripMenu_File.Image");
            toolStripMenu_File.ImageTransparentColor = Color.Magenta;
            toolStripMenu_File.Name = "toolStripMenu_File";
            toolStripMenu_File.ShowDropDownArrow = false;
            toolStripMenu_File.Size = new Size(58, 22);
            toolStripMenu_File.Text = "파일(&F)";
            // 
            // toolStripItem_New
            // 
            toolStripItem_New.Name = "toolStripItem_New";
            toolStripItem_New.ShortcutKeyDisplayString = "";
            toolStripItem_New.ShortcutKeys = Keys.Control | Keys.N;
            toolStripItem_New.Size = new Size(268, 22);
            toolStripItem_New.Text = "새로 만들기(&N)";
            // 
            // toolStripItem_Open
            // 
            toolStripItem_Open.Name = "toolStripItem_Open";
            toolStripItem_Open.ShortcutKeys = Keys.Control | Keys.O;
            toolStripItem_Open.Size = new Size(268, 22);
            toolStripItem_Open.Text = "열기(&O)";
            // 
            // toolStripItem_Save
            // 
            toolStripItem_Save.Name = "toolStripItem_Save";
            toolStripItem_Save.ShortcutKeyDisplayString = "";
            toolStripItem_Save.ShortcutKeys = Keys.Control | Keys.S;
            toolStripItem_Save.Size = new Size(268, 22);
            toolStripItem_Save.Text = "저장(&S)";
            // 
            // toolStripItem_SaveAs
            // 
            toolStripItem_SaveAs.Name = "toolStripItem_SaveAs";
            toolStripItem_SaveAs.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            toolStripItem_SaveAs.Size = new Size(268, 22);
            toolStripItem_SaveAs.Text = "다른 이름으로 저장(&A)";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(265, 6);
            // 
            // toolStripItem_Setting
            // 
            toolStripItem_Setting.Name = "toolStripItem_Setting";
            toolStripItem_Setting.Size = new Size(268, 22);
            toolStripItem_Setting.Text = "옵션(&E)";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(265, 6);
            // 
            // toolStripItem_Exit
            // 
            toolStripItem_Exit.Name = "toolStripItem_Exit";
            toolStripItem_Exit.Size = new Size(268, 22);
            toolStripItem_Exit.Text = "끝내기(&X)";
            // 
            // toolStripMenu_Edit
            // 
            toolStripMenu_Edit.AutoSize = false;
            toolStripMenu_Edit.AutoToolTip = false;
            toolStripMenu_Edit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenu_Edit.DropDownItems.AddRange(new ToolStripItem[] { toolStripItem_Undo, toolStripItem_Redo, toolStripSeparator3, toolStripItem_Cut, toolStripItem_Copy, toolStripItem_Paste, toolStripItem_Del, toolStripSeparator4, toolStripItem_AllSelect });
            toolStripMenu_Edit.Image = (Image)resources.GetObject("toolStripMenu_Edit.Image");
            toolStripMenu_Edit.ImageTransparentColor = Color.Magenta;
            toolStripMenu_Edit.Name = "toolStripMenu_Edit";
            toolStripMenu_Edit.ShowDropDownArrow = false;
            toolStripMenu_Edit.Size = new Size(58, 22);
            toolStripMenu_Edit.Text = "편집(&E)";
            // 
            // toolStripItem_Undo
            // 
            toolStripItem_Undo.Name = "toolStripItem_Undo";
            toolStripItem_Undo.ShortcutKeys = Keys.Control | Keys.Z;
            toolStripItem_Undo.Size = new Size(184, 22);
            toolStripItem_Undo.Text = "실행 취소(&U)";
            // 
            // toolStripItem_Redo
            // 
            toolStripItem_Redo.Name = "toolStripItem_Redo";
            toolStripItem_Redo.ShortcutKeys = Keys.Control | Keys.Y;
            toolStripItem_Redo.Size = new Size(184, 22);
            toolStripItem_Redo.Text = "다시 실행(&R)";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(181, 6);
            // 
            // toolStripItem_Cut
            // 
            toolStripItem_Cut.Name = "toolStripItem_Cut";
            toolStripItem_Cut.ShortcutKeys = Keys.Control | Keys.X;
            toolStripItem_Cut.Size = new Size(184, 22);
            toolStripItem_Cut.Text = "잘라내기(&T)";
            // 
            // toolStripItem_Copy
            // 
            toolStripItem_Copy.Name = "toolStripItem_Copy";
            toolStripItem_Copy.ShortcutKeys = Keys.Control | Keys.C;
            toolStripItem_Copy.Size = new Size(184, 22);
            toolStripItem_Copy.Text = "복사(&C)";
            // 
            // toolStripItem_Paste
            // 
            toolStripItem_Paste.Name = "toolStripItem_Paste";
            toolStripItem_Paste.ShortcutKeys = Keys.Control | Keys.V;
            toolStripItem_Paste.Size = new Size(184, 22);
            toolStripItem_Paste.Text = "붙여넣기(&P)";
            // 
            // toolStripItem_Del
            // 
            toolStripItem_Del.Name = "toolStripItem_Del";
            toolStripItem_Del.ShortcutKeyDisplayString = "Del";
            toolStripItem_Del.ShortcutKeys = Keys.Delete;
            toolStripItem_Del.Size = new Size(184, 22);
            toolStripItem_Del.Text = "삭제(&D)";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(181, 6);
            // 
            // toolStripItem_AllSelect
            // 
            toolStripItem_AllSelect.Name = "toolStripItem_AllSelect";
            toolStripItem_AllSelect.ShortcutKeys = Keys.Control | Keys.A;
            toolStripItem_AllSelect.Size = new Size(184, 22);
            toolStripItem_AllSelect.Text = "모두 선택(&A)";
            // 
            // toolStripMenu_Capture
            // 
            toolStripMenu_Capture.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenu_Capture.DropDownItems.AddRange(new ToolStripItem[] { toolStripItem_CaptToggle, toolStripSeparator8, toolStripItem_CaptChange });
            toolStripMenu_Capture.Image = (Image)resources.GetObject("toolStripMenu_Capture.Image");
            toolStripMenu_Capture.ImageTransparentColor = Color.Magenta;
            toolStripMenu_Capture.Name = "toolStripMenu_Capture";
            toolStripMenu_Capture.ShowDropDownArrow = false;
            toolStripMenu_Capture.Size = new Size(51, 22);
            toolStripMenu_Capture.Text = "캡쳐(&C)";
            // 
            // toolStripItem_CaptToggle
            // 
            toolStripItem_CaptToggle.Checked = true;
            toolStripItem_CaptToggle.CheckState = CheckState.Checked;
            toolStripItem_CaptToggle.Name = "toolStripItem_CaptToggle";
            toolStripItem_CaptToggle.Size = new Size(181, 22);
            toolStripItem_CaptToggle.Text = "캡쳐 화면 활성화(&R)";
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(178, 6);
            // 
            // toolStripItem_CaptChange
            // 
            toolStripItem_CaptChange.DropDownItems.AddRange(new ToolStripItem[] { toolStripItem_CaptAll, toolStripItem_CaptSingle });
            toolStripItem_CaptChange.Name = "toolStripItem_CaptChange";
            toolStripItem_CaptChange.Size = new Size(181, 22);
            toolStripItem_CaptChange.Text = "캡쳐 종류 변경(&C)";
            // 
            // toolStripItem_CaptAll
            // 
            toolStripItem_CaptAll.Name = "toolStripItem_CaptAll";
            toolStripItem_CaptAll.Size = new Size(141, 22);
            toolStripItem_CaptAll.Text = "전체 캡쳐(&B)";
            // 
            // toolStripItem_CaptSingle
            // 
            toolStripItem_CaptSingle.Name = "toolStripItem_CaptSingle";
            toolStripItem_CaptSingle.Size = new Size(141, 22);
            toolStripItem_CaptSingle.Text = "단일 캡쳐(&S)";
            // 
            // contextMenu_Empty
            // 
            contextMenu_Empty.Items.AddRange(new ToolStripItem[] { emptyMenuItem__Add, toolStripSeparator5, emptyMenuItem_Paste, emptyMenuItem_AllSelect, toolStripSeparator6, emptyMenuItem_Undo, emptyMenuItem_Redo });
            contextMenu_Empty.Name = "contextMenuStrip";
            contextMenu_Empty.Size = new Size(143, 126);
            // 
            // emptyMenuItem__Add
            // 
            emptyMenuItem__Add.DropDownItems.AddRange(new ToolStripItem[] { emptyMenuItem_CardAdd, emptyMenuItem_TextAdd });
            emptyMenuItem__Add.Name = "emptyMenuItem__Add";
            emptyMenuItem__Add.Size = new Size(142, 22);
            emptyMenuItem__Add.Text = "추가(&C)";
            // 
            // emptyMenuItem_CardAdd
            // 
            emptyMenuItem_CardAdd.Name = "emptyMenuItem_CardAdd";
            emptyMenuItem_CardAdd.Size = new Size(138, 22);
            emptyMenuItem_CardAdd.Text = "카드 추가";
            // 
            // emptyMenuItem_TextAdd
            // 
            emptyMenuItem_TextAdd.Name = "emptyMenuItem_TextAdd";
            emptyMenuItem_TextAdd.Size = new Size(138, 22);
            emptyMenuItem_TextAdd.Text = "텍스트 추가";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(139, 6);
            // 
            // emptyMenuItem_Paste
            // 
            emptyMenuItem_Paste.Name = "emptyMenuItem_Paste";
            emptyMenuItem_Paste.Size = new Size(142, 22);
            emptyMenuItem_Paste.Text = "붙여넣기&P)";
            // 
            // emptyMenuItem_AllSelect
            // 
            emptyMenuItem_AllSelect.Name = "emptyMenuItem_AllSelect";
            emptyMenuItem_AllSelect.Size = new Size(142, 22);
            emptyMenuItem_AllSelect.Text = "모두선택(&A)";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(139, 6);
            // 
            // emptyMenuItem_Undo
            // 
            emptyMenuItem_Undo.Name = "emptyMenuItem_Undo";
            emptyMenuItem_Undo.Size = new Size(142, 22);
            emptyMenuItem_Undo.Text = "실행 취소(&U)";
            // 
            // emptyMenuItem_Redo
            // 
            emptyMenuItem_Redo.Name = "emptyMenuItem_Redo";
            emptyMenuItem_Redo.Size = new Size(142, 22);
            emptyMenuItem_Redo.Text = "다시 실행(&R)";
            // 
            // contextMenu_Text
            // 
            contextMenu_Text.Items.AddRange(new ToolStripItem[] { textMenuItem_Change, textMenuItem_Delete, textMenuItem_Rotate, toolStripSeparator7, 서식WToolStripMenuItem });
            contextMenu_Text.Name = "ContextMenu_Card";
            contextMenu_Text.Size = new Size(156, 98);
            // 
            // textMenuItem_Change
            // 
            textMenuItem_Change.Name = "textMenuItem_Change";
            textMenuItem_Change.Size = new Size(155, 22);
            textMenuItem_Change.Text = "내용 변경(&C)";
            // 
            // textMenuItem_Delete
            // 
            textMenuItem_Delete.Name = "textMenuItem_Delete";
            textMenuItem_Delete.Size = new Size(155, 22);
            textMenuItem_Delete.Text = "텍스트 삭제(&D)";
            // 
            // textMenuItem_Rotate
            // 
            textMenuItem_Rotate.Name = "textMenuItem_Rotate";
            textMenuItem_Rotate.Size = new Size(155, 22);
            textMenuItem_Rotate.Text = "텍스트 회전(&R)";
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(152, 6);
            // 
            // 서식WToolStripMenuItem
            // 
            서식WToolStripMenuItem.Name = "서식WToolStripMenuItem";
            서식WToolStripMenuItem.Size = new Size(155, 22);
            서식WToolStripMenuItem.Text = "서식(&O)";
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { 새로만들기NToolStripButton, 열기OToolStripButton, 저장SToolStripButton, toolStripSeparator, 잘라내기UToolStripButton, 복사CToolStripButton, 붙여넣기PToolStripButton, toolStripSeparator9, toolStripComboBox1, toolStripButton1 });
            toolStrip1.Location = new Point(0, 25);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1077, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // 새로만들기NToolStripButton
            // 
            새로만들기NToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            새로만들기NToolStripButton.Image = (Image)resources.GetObject("새로만들기NToolStripButton.Image");
            새로만들기NToolStripButton.ImageTransparentColor = Color.Magenta;
            새로만들기NToolStripButton.Name = "새로만들기NToolStripButton";
            새로만들기NToolStripButton.Size = new Size(23, 22);
            새로만들기NToolStripButton.Text = "새로 만들기(&N)";
            // 
            // 열기OToolStripButton
            // 
            열기OToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            열기OToolStripButton.Image = (Image)resources.GetObject("열기OToolStripButton.Image");
            열기OToolStripButton.ImageTransparentColor = Color.Magenta;
            열기OToolStripButton.Name = "열기OToolStripButton";
            열기OToolStripButton.Size = new Size(23, 22);
            열기OToolStripButton.Text = "열기(&O)";
            // 
            // 저장SToolStripButton
            // 
            저장SToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            저장SToolStripButton.Image = (Image)resources.GetObject("저장SToolStripButton.Image");
            저장SToolStripButton.ImageTransparentColor = Color.Magenta;
            저장SToolStripButton.Name = "저장SToolStripButton";
            저장SToolStripButton.Size = new Size(23, 22);
            저장SToolStripButton.Text = "저장(&S)";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
            // 
            // 잘라내기UToolStripButton
            // 
            잘라내기UToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            잘라내기UToolStripButton.Image = (Image)resources.GetObject("잘라내기UToolStripButton.Image");
            잘라내기UToolStripButton.ImageTransparentColor = Color.Magenta;
            잘라내기UToolStripButton.Name = "잘라내기UToolStripButton";
            잘라내기UToolStripButton.Size = new Size(23, 22);
            잘라내기UToolStripButton.Text = "잘라내기(&U)";
            // 
            // 복사CToolStripButton
            // 
            복사CToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            복사CToolStripButton.Image = (Image)resources.GetObject("복사CToolStripButton.Image");
            복사CToolStripButton.ImageTransparentColor = Color.Magenta;
            복사CToolStripButton.Name = "복사CToolStripButton";
            복사CToolStripButton.Size = new Size(23, 22);
            복사CToolStripButton.Text = "복사(&C)";
            // 
            // 붙여넣기PToolStripButton
            // 
            붙여넣기PToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            붙여넣기PToolStripButton.Image = (Image)resources.GetObject("붙여넣기PToolStripButton.Image");
            붙여넣기PToolStripButton.ImageTransparentColor = Color.Magenta;
            붙여넣기PToolStripButton.Name = "붙여넣기PToolStripButton";
            붙여넣기PToolStripButton.Size = new Size(23, 22);
            붙여넣기PToolStripButton.Text = "붙여넣기(&P)";
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(6, 25);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox1.Items.AddRange(new object[] { "전체 캡쳐", "단일 캡쳐" });
            toolStripComboBox1.MaxDropDownItems = 2;
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 25);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // TaroStudio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 574);
            Controls.Add(toolStrip1);
            Controls.Add(toolStripTop);
            Name = "TaroStudio";
            Text = "Taro Studio";
            Load += TaroStudio_Load;
            toolStripTop.ResumeLayout(false);
            toolStripTop.PerformLayout();
            contextMenu_Card.ResumeLayout(false);
            contextMenu_Empty.ResumeLayout(false);
            contextMenu_Text.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStripTop;
        private ToolStrip toolStripTop2;
        private ContextMenuStrip contextMenu_Empty;
        private ToolStripMenuItem emptyMenuItem__Add;
        private ToolStripMenuItem emptyMenuItem_CardAdd;
        private ToolStripMenuItem emptyMenuItem_TextAdd;
        private ContextMenuStrip contextMenu_Card;
        private ToolStripMenuItem cardMenuItem_Change;
        private ToolStripMenuItem cardMenuItem_Delete;
        private ToolStripDropDownButton toolStripMenu_File;
        private ToolStripMenuItem toolStripItem_Setting;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripItem_Exit;
        private ToolStripMenuItem toolStripItem_New;
        private ToolStripMenuItem toolStripItem_Open;
        private ToolStripMenuItem toolStripItem_Save;
        private ToolStripMenuItem toolStripItem_SaveAs;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton toolStripMenu_Edit;
        private ToolStripMenuItem toolStripItem_Undo;
        private ToolStripMenuItem toolStripItem_Redo;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem toolStripItem_Cut;
        private ToolStripMenuItem toolStripItem_Copy;
        private ToolStripMenuItem toolStripItem_Paste;
        private ToolStripMenuItem toolStripItem_Del;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem toolStripItem_AllSelect;
        private ToolStripButton toolStripImg_New;
        private ToolStripButton toolStripImg_Open;
        private ToolStripButton toolStripImg_Save;
        private ToolStripButton toolStripImg_Back;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem emptyMenuItem_Paste;
        private ToolStripMenuItem emptyMenuItem_AllSelect;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem emptyMenuItem_Undo;
        private ToolStripMenuItem emptyMenuItem_Redo;
        private ToolStripMenuItem cardMenuItem_Reverse;
        private ToolStripMenuItem cardMenuItem_Rotate;
        private ContextMenuStrip contextMenu_Text;
        private ToolStripMenuItem textMenuItem_Change;
        private ToolStripMenuItem textMenuItem_Delete;
        private ToolStripMenuItem textMenuItem_Rotate;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem 서식WToolStripMenuItem;
        private ToolStripDropDownButton toolStripMenu_Capture;
        private ToolStripMenuItem toolStripItem_CaptToggle;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem toolStripItem_CaptChange;
        private ToolStripMenuItem toolStripItem_CaptAll;
        private ToolStripMenuItem toolStripItem_CaptSingle;
        private ToolStrip toolStrip1;
        private ToolStripButton 새로만들기NToolStripButton;
        private ToolStripButton 열기OToolStripButton;
        private ToolStripButton 저장SToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton 잘라내기UToolStripButton;
        private ToolStripButton 복사CToolStripButton;
        private ToolStripButton 붙여넣기PToolStripButton;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripButton toolStripButton1;
    }
}