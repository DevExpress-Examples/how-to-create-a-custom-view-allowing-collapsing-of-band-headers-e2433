﻿Namespace BandedViewBandDefaultColumn
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.myGridControl1 = New BandedViewBandDefaultColumn.MyGridControl()
            Me.myBandedGridView1 = New BandedViewBandDefaultColumn.MyBandedGridView()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.myBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' myGridControl1
            ' 
            Me.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.myGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.myGridControl1.MainView = Me.myBandedGridView1
            Me.myGridControl1.Name = "myGridControl1"
            Me.myGridControl1.Size = New System.Drawing.Size(450, 398)
            Me.myGridControl1.TabIndex = 0
            Me.myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.myBandedGridView1})
            ' 
            ' myBandedGridView1
            ' 
            Me.myBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1})
            Me.myBandedGridView1.GridControl = Me.myGridControl1
            Me.myBandedGridView1.Name = "myBandedGridView1"
            ' 
            ' gridBand1
            ' 
            Me.gridBand1.Caption = "gridBand1"
            Me.gridBand1.Name = "gridBand1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(450, 398)
            Me.Controls.Add(Me.myGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.myBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private myGridControl1 As MyGridControl
        Private myBandedGridView1 As MyBandedGridView
        Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    End Class
End Namespace

