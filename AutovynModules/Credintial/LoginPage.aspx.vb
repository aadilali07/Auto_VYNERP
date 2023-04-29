Public Class LoginPage
    Inherits System.Web.UI.Page

    Public Shared newstring As String
    Public Shared clientid As String
    Public Shared locpath1 As String

    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("user_name") = ""
        newstring = Session("user_name")
        If Not IsPostBack Then

        End If
    End Sub

    Public Sub MesgBox(ByVal sMessage As String)
        ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('" & sMessage & "')", True)
    End Sub

    'Private Function RetMyArr(ByVal PymtMode As String) As Integer
    '    Dim RetVal As Integer
    '    Try
    '        If PymtMode = "True Value" Then RetVal = 4
    '        If PymtMode = "Retail" Then RetVal = 5
    '        If PymtMode = "Payroll" Then RetVal = 6
    '        If PymtMode = "DSE" Then RetVal = 9
    '        If PymtMode = "Financier" Then RetVal = 10
    '        If PymtMode = "Insurance" Then RetVal = 11
    '    Catch ex As Exception

    '    End Try
    '    Return RetVal
    'End Function

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Try

            If Dealer_ID.Text <> "" And User_Name.Text <> "" And inputPassword.Text <> "" Then
                clientid = Dealer_ID.Text
                QueryInit("BRANCH_MST")
                QueryInit("CHASSIS_MST")
                QueryInit("FINANCE_MST")
                QueryInit("COLOR_MST")
                QueryInit("LOAN_MST")
                QueryInit("VEH_MST")
                QueryInit("EMPLOYEEMASTER")
                QueryInit("MODEL_MST")
                QueryInit("STATE_MST")
                QueryInit("OLDCHASS_NO")

                Session("CLIENTID") = Dealer_ID.Text

                Dim empDT As DataTable
                Dim dt1 As DataTable
                Dim Con As New Connection
                Dim empPos As String
                empDT = Con.ReturnDtTable("select emp_pos from user_tbl where Export_Type<3 and user_name='" & User_Name.Text & "' and user_pwd='" & inputPassword.Text & "'")
                empPos = empDT.Rows(0)("emp_pos").ToString
                Con = New Connection
                Dim dt As DataTable
                dt = Con.ReturnDtTable("Select * from user_tbl where Export_Type<3 and user_name='" & User_Name.Text & "' and user_pwd='" & inputPassword.Text & "'")

                dt1 = Con.ReturnDtTable("Select * from database_testing_connection where  user_name='" & User_Name.Text & "' and password='" & inputPassword.Text & "'")

                If dt.Rows.Count > 0 Then
                    Session("user_name") = User_Name.Text
                    Session("EmpPos") = empPos
                    Session("Log_code") = Val(dt.Rows(0)("User_Code").ToString)
                    Session("login_name") = dt.Rows(0)("User_Name").ToString
                    Session("QueryLoc") = dt.Rows(0)("Multi_Loc").ToString
                    newstring = Session("user_name")
                Else

                End If

                'If dt1.Rows.Count > 0 Then
                '    Session("data_source") = dt1.Rows(0)("dbData_Source")
                '    Session("int_cat") = dt1.Rows(0)("dbinitial_catalog")
                '    Session("user_id") = dt1.Rows(0)("dbuser_id")
                '    Session("pwd") = dt1.Rows(0)("dbpassword")
                '    Session("intsec") = dt1.Rows(0)("integerated_sec")

                'locpath1 = "Data Source=" & Session("data_source") & ";Initial Catalog=" & Session("int_cat") & ";User ID=" & Session("user_id") & ";Password=" & Session("pwd") & ";Integrated Security=" & Session("intsec") & ""


                'Else
                '    newstring = ""
                'End If

                Response.Redirect("Loader.aspx")


            Else
                '  MsgBox("")
            End If

        Catch ex As Exception

        End Try

    End Sub



    Private Sub app_Click(sender As Object, e As EventArgs) Handles hide.Click
        Response.Redirect("../../EMP_A/Credintials/Index.aspx")
    End Sub
End Class