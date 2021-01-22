
namespace YS_scrtaskboard.Formlar
{
    partial class frmDurumizle
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
            this.components = new System.ComponentModel.Container();
            this.fTeknikKartDetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewGorevDurumDetayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwTodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControlTodo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlRevision = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlCheck = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlDone = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlinProgress = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.dragDropEvents1 = new DevExpress.Utils.DragDrop.DragDropEvents(this.components);
            this.dragDropEvents2 = new DevExpress.Utils.DragDrop.DragDropEvents(this.components);
            this.dragDropEvents3 = new DevExpress.Utils.DragDrop.DragDropEvents(this.components);
            this.dragDropEvents4 = new DevExpress.Utils.DragDrop.DragDropEvents(this.components);
            this.dragDropEvents5 = new DevExpress.Utils.DragDrop.DragDropEvents(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fTeknikKartDetayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGorevDurumDetayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTodoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRevision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlinProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fTeknikKartDetayBindingSource
            // 
            this.fTeknikKartDetayBindingSource.DataMember = "f_TeknikKartDetay";
            // 
            // viewGorevDurumDetayBindingSource
            // 
            this.viewGorevDurumDetayBindingSource.DataMember = "view_GorevDurumDetay";
            // 
            // gridControlTodo
            // 
            this.gridControlTodo.AllowDrop = true;
            this.gridControlTodo.Location = new System.Drawing.Point(12, 23);
            this.gridControlTodo.MainView = this.gridView1;
            this.gridControlTodo.Name = "gridControlTodo";
            this.gridControlTodo.Size = new System.Drawing.Size(194, 554);
            this.gridControlTodo.TabIndex = 0;
            this.gridControlTodo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControlTodo.DragDrop += new System.Windows.Forms.DragEventHandler(this.gridControlTodo_DragDrop);
            this.gridControlTodo.DragOver += new System.Windows.Forms.DragEventHandler(this.gridControlTodo_DragOver);
            // 
            // gridView1
            // 
            this.behaviorManager1.SetBehaviors(this.gridView1, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.DragDrop.DragDropBehavior.Create(typeof(DevExpress.XtraGrid.Extensions.ColumnViewDragDropSource), true, true, true, true, this.dragDropEvents1)))});
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gridView1.GridControl = this.gridControlTodo;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridControlRevision
            // 
            this.gridControlRevision.AllowDrop = true;
            this.gridControlRevision.Location = new System.Drawing.Point(412, 23);
            this.gridControlRevision.MainView = this.gridView2;
            this.gridControlRevision.Name = "gridControlRevision";
            this.gridControlRevision.Size = new System.Drawing.Size(194, 554);
            this.gridControlRevision.TabIndex = 1;
            this.gridControlRevision.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControlRevision.DragDrop += new System.Windows.Forms.DragEventHandler(this.gridControlRevision_DragDrop);
            this.gridControlRevision.DragOver += new System.Windows.Forms.DragEventHandler(this.gridControlRevision_DragOver);
            // 
            // gridView2
            // 
            this.behaviorManager1.SetBehaviors(this.gridView2, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.DragDrop.DragDropBehavior.Create(typeof(DevExpress.XtraGrid.Extensions.ColumnViewDragDropSource), true, true, true, true, this.dragDropEvents2)))});
            this.gridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gridView2.GridControl = this.gridControlRevision;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridControlCheck
            // 
            this.gridControlCheck.AllowDrop = true;
            this.gridControlCheck.Location = new System.Drawing.Point(612, 23);
            this.gridControlCheck.MainView = this.gridView3;
            this.gridControlCheck.Name = "gridControlCheck";
            this.gridControlCheck.Size = new System.Drawing.Size(194, 554);
            this.gridControlCheck.TabIndex = 2;
            this.gridControlCheck.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            this.gridControlCheck.DragDrop += new System.Windows.Forms.DragEventHandler(this.gridControlCheck_DragDrop);
            this.gridControlCheck.DragOver += new System.Windows.Forms.DragEventHandler(this.gridControlCheck_DragOver);
            // 
            // gridView3
            // 
            this.behaviorManager1.SetBehaviors(this.gridView3, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.DragDrop.DragDropBehavior.Create(typeof(DevExpress.XtraGrid.Extensions.ColumnViewDragDropSource), true, true, true, true, this.dragDropEvents3)))});
            this.gridView3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gridView3.GridControl = this.gridControlCheck;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridControlDone
            // 
            this.gridControlDone.AllowDrop = true;
            this.gridControlDone.Location = new System.Drawing.Point(812, 23);
            this.gridControlDone.MainView = this.gridView4;
            this.gridControlDone.Name = "gridControlDone";
            this.gridControlDone.Size = new System.Drawing.Size(194, 554);
            this.gridControlDone.TabIndex = 3;
            this.gridControlDone.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            this.gridControlDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.gridControlDone_DragDrop);
            this.gridControlDone.DragOver += new System.Windows.Forms.DragEventHandler(this.gridControlDone_DragOver);
            // 
            // gridView4
            // 
            this.behaviorManager1.SetBehaviors(this.gridView4, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.DragDrop.DragDropBehavior.Create(typeof(DevExpress.XtraGrid.Extensions.ColumnViewDragDropSource), true, true, true, true, this.dragDropEvents4)))});
            this.gridView4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gridView4.GridControl = this.gridControlDone;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // gridControlinProgress
            // 
            this.gridControlinProgress.AllowDrop = true;
            this.gridControlinProgress.Location = new System.Drawing.Point(212, 23);
            this.gridControlinProgress.MainView = this.gridView5;
            this.gridControlinProgress.Name = "gridControlinProgress";
            this.gridControlinProgress.Size = new System.Drawing.Size(194, 554);
            this.gridControlinProgress.TabIndex = 4;
            this.gridControlinProgress.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            this.gridControlinProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.gridControlinProgress_DragDrop);
            this.gridControlinProgress.DragOver += new System.Windows.Forms.DragEventHandler(this.gridControlinProgress_DragOver);
            // 
            // gridView5
            // 
            this.behaviorManager1.SetBehaviors(this.gridView5, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.DragDrop.DragDropBehavior.Create(typeof(DevExpress.XtraGrid.Extensions.ColumnViewDragDropSource), true, true, true, true, this.dragDropEvents5)))});
            this.gridView5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gridView5.GridControl = this.gridControlinProgress;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(50, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "YAPILACAK";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(880, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "TAMAMLANDI";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(675, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "KONTROL";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(484, 6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "DÜZELTME";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(270, 6);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(85, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "DEVAM EDİYOR";
            // 
            // frmDurumizle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 655);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControlinProgress);
            this.Controls.Add(this.gridControlDone);
            this.Controls.Add(this.gridControlCheck);
            this.Controls.Add(this.gridControlRevision);
            this.Controls.Add(this.gridControlTodo);
            this.Name = "frmDurumizle";
            this.Text = "DURUM İZLEME SCRUM TASK BOARD";
            this.Load += new System.EventHandler(this.frmDurumizle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fTeknikKartDetayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGorevDurumDetayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwTodoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRevision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlinProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource fTeknikKartDetayBindingSource;
       // private YSprojeDataSetTableAdapters.f_TeknikKartDetayTableAdapter f_TeknikKartDetayTableAdapter;
        private System.Windows.Forms.BindingSource viewGorevDurumDetayBindingSource;
 //       private YSprojeDataSet ySprojeDataSet;
        private System.Windows.Forms.BindingSource vwTodoBindingSource;
        private DevExpress.XtraGrid.GridControl gridControlTodo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControlRevision;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControlCheck;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.GridControl gridControlDone;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.GridControl gridControlinProgress;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.Utils.DragDrop.DragDropEvents dragDropEvents1;
        private DevExpress.Utils.DragDrop.DragDropEvents dragDropEvents2;
        private DevExpress.Utils.DragDrop.DragDropEvents dragDropEvents3;
        private DevExpress.Utils.DragDrop.DragDropEvents dragDropEvents4;
        private DevExpress.Utils.DragDrop.DragDropEvents dragDropEvents5;
        //       private YSprojeDataSetTableAdapters.vw_TodoTableAdapter vw_TodoTableAdapter;
        //  private YSprojeDataSetTableAdapters.view_GorevDurumDetayTableAdapter view_GorevDurumDetayTableAdapter;
    }
}