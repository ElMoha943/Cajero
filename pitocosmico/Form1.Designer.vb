<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Imprimir = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label_Product_Name = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Producto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Precio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_Descuento = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label_Id_Producto = New System.Windows.Forms.Label()
        Me.Limpiar_Lista = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MenuVertical = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.Ventas = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Caja = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel8.SuspendLayout()
        Me.MenuVertical.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(133, 150)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(107, 23)
        Me.Eliminar.TabIndex = 3
        Me.Eliminar.Text = "Eliminar Seleccion"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Imprimir
        '
        Me.Imprimir.Location = New System.Drawing.Point(133, 312)
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(200, 87)
        Me.Imprimir.TabIndex = 4
        Me.Imprimir.Text = "Imprimir"
        Me.Imprimir.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(269, 172)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(85, 17)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Targeta Visa"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(269, 150)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(64, 17)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Efectivo"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(133, 70)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label_Product_Name
        '
        Me.Label_Product_Name.AutoSize = True
        Me.Label_Product_Name.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Product_Name.Location = New System.Drawing.Point(128, 23)
        Me.Label_Product_Name.Name = "Label_Product_Name"
        Me.Label_Product_Name.Size = New System.Drawing.Size(236, 28)
        Me.Label_Product_Name.TabIndex = 8
        Me.Label_Product_Name.Text = "NOMBRE DEL PRODUCTO"
        Me.Label_Product_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_Product_Name.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(477, 418)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 28)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "TOTAL:"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Producto, Me.Precio})
        Me.ListView1.HideSelection = False
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem3})
        Me.ListView1.Location = New System.Drawing.Point(472, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(200, 404)
        Me.ListView1.TabIndex = 10
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(269, 191)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(118, 17)
        Me.RadioButton3.TabIndex = 11
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Targeta Mastercard"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(264, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 28)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Tipo de pago"
        '
        'Label_Descuento
        '
        Me.Label_Descuento.AutoSize = True
        Me.Label_Descuento.Font = New System.Drawing.Font("Nirmala UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Descuento.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label_Descuento.Location = New System.Drawing.Point(477, 451)
        Me.Label_Descuento.Name = "Label_Descuento"
        Me.Label_Descuento.Size = New System.Drawing.Size(76, 19)
        Me.Label_Descuento.TabIndex = 13
        Me.Label_Descuento.Text = "Descuento:"
        Me.Label_Descuento.Visible = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label_Id_Producto)
        Me.Panel8.Controls.Add(Me.Limpiar_Lista)
        Me.Panel8.Controls.Add(Me.Label_Product_Name)
        Me.Panel8.Controls.Add(Me.Eliminar)
        Me.Panel8.Controls.Add(Me.Label_Descuento)
        Me.Panel8.Controls.Add(Me.Imprimir)
        Me.Panel8.Controls.Add(Me.ListView1)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Controls.Add(Me.Label2)
        Me.Panel8.Controls.Add(Me.RadioButton1)
        Me.Panel8.Controls.Add(Me.RadioButton3)
        Me.Panel8.Controls.Add(Me.RadioButton2)
        Me.Panel8.Controls.Add(Me.TextBox1)
        Me.Panel8.Location = New System.Drawing.Point(229, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(685, 488)
        Me.Panel8.TabIndex = 15
        '
        'Label_Id_Producto
        '
        Me.Label_Id_Producto.AutoSize = True
        Me.Label_Id_Producto.Font = New System.Drawing.Font("Nirmala UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Id_Producto.Location = New System.Drawing.Point(13, 71)
        Me.Label_Id_Producto.Name = "Label_Id_Producto"
        Me.Label_Id_Producto.Size = New System.Drawing.Size(101, 19)
        Me.Label_Id_Producto.TabIndex = 15
        Me.Label_Id_Producto.Text = "ID PRODUCTO:"
        '
        'Limpiar_Lista
        '
        Me.Limpiar_Lista.Location = New System.Drawing.Point(133, 185)
        Me.Limpiar_Lista.Name = "Limpiar_Lista"
        Me.Limpiar_Lista.Size = New System.Drawing.Size(107, 23)
        Me.Limpiar_Lista.TabIndex = 14
        Me.Limpiar_Lista.Text = "Limpiar Lista"
        Me.Limpiar_Lista.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(232, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(681, 484)
        Me.Panel3.TabIndex = 16
        '
        'MenuVertical
        '
        Me.MenuVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MenuVertical.Controls.Add(Me.Panel3)
        Me.MenuVertical.Controls.Add(Me.PictureBox2)
        Me.MenuVertical.Controls.Add(Me.panel2)
        Me.MenuVertical.Controls.Add(Me.Ventas)
        Me.MenuVertical.Controls.Add(Me.panel1)
        Me.MenuVertical.Controls.Add(Me.Caja)
        Me.MenuVertical.Controls.Add(Me.pictureBox1)
        Me.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuVertical.Location = New System.Drawing.Point(0, 0)
        Me.MenuVertical.Name = "MenuVertical"
        Me.MenuVertical.Size = New System.Drawing.Size(233, 488)
        Me.MenuVertical.TabIndex = 16
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(43, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel2.Location = New System.Drawing.Point(0, 172)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(5, 32)
        Me.panel2.TabIndex = 4
        '
        'Ventas
        '
        Me.Ventas.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Ventas.FlatAppearance.BorderSize = 0
        Me.Ventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ventas.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ventas.ForeColor = System.Drawing.Color.White
        Me.Ventas.Image = CType(resources.GetObject("Ventas.Image"), System.Drawing.Image)
        Me.Ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ventas.Location = New System.Drawing.Point(3, 172)
        Me.Ventas.Name = "Ventas"
        Me.Ventas.Size = New System.Drawing.Size(217, 32)
        Me.Ventas.TabIndex = 3
        Me.Ventas.Text = "Ventas"
        Me.Ventas.UseVisualStyleBackColor = False
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panel1.Location = New System.Drawing.Point(0, 134)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(5, 32)
        Me.panel1.TabIndex = 2
        '
        'Caja
        '
        Me.Caja.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Caja.FlatAppearance.BorderSize = 0
        Me.Caja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Caja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Caja.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Caja.ForeColor = System.Drawing.Color.White
        Me.Caja.Image = CType(resources.GetObject("Caja.Image"), System.Drawing.Image)
        Me.Caja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Caja.Location = New System.Drawing.Point(3, 134)
        Me.Caja.Name = "Caja"
        Me.Caja.Size = New System.Drawing.Size(217, 32)
        Me.Caja.TabIndex = 1
        Me.Caja.Text = "Caja"
        Me.Caja.UseVisualStyleBackColor = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(220, 102)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(914, 488)
        Me.Controls.Add(Me.MenuVertical)
        Me.Controls.Add(Me.Panel8)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.MenuVertical.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Eliminar As Button
    Friend WithEvents Imprimir As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label_Product_Name As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Producto As ColumnHeader
    Friend WithEvents Precio As ColumnHeader
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_Descuento As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Limpiar_Lista As Button
    Friend WithEvents Label_Id_Producto As Label
    Private WithEvents MenuVertical As Panel
    Private WithEvents panel2 As Panel
    Private WithEvents Ventas As Button
    Private WithEvents panel1 As Panel
    Private WithEvents Caja As Button
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
End Class
