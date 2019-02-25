Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmLab12
    Dim strCon As String = ConfigurationManager.ConnectionStrings("SalaryBySurasak.My.MySettings.Mycon1").ConnectionString
    Dim myCon As New SqlConnection

    Dim myDA As New SqlDataAdapter
    Dim MyDS As New DataSet


    Dim myComm As New SqlCommand
    Dim myDR As SqlDataReader


    Dim strSql As String
    

    Private Sub frmLab12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Myconnect()
        strSql = "select empId,empName,empLName,Salary,depName from tbDepartment,tbEmployee where tbDepartment.depId = tbEmployee.depId "
        myDA = New SqlDataAdapter(strSql, myCon)
        MyDS.Clear()
        myDA.Fill(MyDS, "showtable")
        DgvEmp.DataSource = MyDS.Tables("showtable")
        myCon.Close()

        depnameShow()
    End Sub

    Private Sub Myconnect()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()

        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub

    Private Sub depnameShow()
        Myconnect()
        strSql = "select depName From tbDepartment order by depName "
        myComm = New SqlCommand(strSql, myCon)


        myComm.CommandTimeout = 15
        myComm.CommandType = CommandType.Text

        myDR = myComm.ExecuteReader()
        If myDR.HasRows Then
            While myDR.Read
                'strName = myDR.Item("CategoryName")
                cboDepart.Items.Add(myDR.Item("depName"))
            End While
            cboDepart.SelectedIndex = 0
            myDR.Close()
            myCon.Close()
        End If


    End Sub

    Private Sub DgvEmp_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvEmp.CellEnter
        Dim r As Integer = DgvEmp.CurrentCell.RowIndex
        Dim pId As String = DgvEmp.Item(0, r).Value

        Myconnect()
        strSql = "select * From tbEmployee,tbDepartment Where tbDepartment.depId =tbEmployee.depId and  empId = @id "
        myComm = New SqlCommand(strSql, myCon)
        myComm.CommandTimeout = 15
        myComm.CommandType = CommandType.Text
        myComm.Parameters.AddWithValue("@id", pId)
        myDR = myComm.ExecuteReader()
        myDR.Read()

        txtEmpId.Text = myDR.Item("empId")
        txtEmpName.Text = myDR.Item("empName")
        txtEmpLName.Text = myDR.Item("empLName")
        txtEmpAdress.Text = myDR.Item("address")
        txtEmpSalary.Text = myDR.Item("salary")
        cboDepart.Text = myDR.Item("depName")
        If myDR.Item("sex") = "Male" Then
            radMale.Checked = True
        Else
            radFemale.Checked = True
        End If



    End Sub
End Class