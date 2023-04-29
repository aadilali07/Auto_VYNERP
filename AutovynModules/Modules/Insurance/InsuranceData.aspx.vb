Public Class InsuranceData
    Inherits System.Web.UI.Page
    Private con As New Connection
    Private dt As New DataTable

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dt = con.ReturnDtTable("select (select FILE_NAME from DOC_UPLOAD where DOC_type='insurance'and tran_id=insu_track.tran_id) as Receipt_img ,Cust_Name,Mobile_Number,Insurance_Amt,(select CONCAT(EMPFIRSTNAME,' ', EMPLASTNAME) AS DSE_NAME from EMPLOYEEMASTER where SRNO=dse_name) as dse_name,location,Recd_amt,Remark from insu_track  where link_status='2'")

        Data_Grid.DataSource = dt
        'Dim imgField As New ImageField()
        'Dim folderPath As String = "~/AutovynModules/Documents/"
        'Dim Filename As String
        'Filename = "Receipt_img"
        'Dim url As String
        'url = folderPath & "" & Filename

        'imgField.DataImageUrlField = url
        'imgField.HeaderText = "Receipt image"
        'Data_Grid.Columns.Add(imgField)

        Data_Grid.DataBind()

        'Try
        '    If Not IsPostBack Then

        '    End If
        '    If Session("user_name") = "" Then
        '        Response.Redirect("../../../Default.aspx")
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    'Protected Sub Candidates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Data_Grid.SelectedIndexChanged
    '    Dim image_url As String
    '    image_url = Data_Grid.SelectedRow.Cells(1).Text
    '    Dim folderPath As String = "~/AutovynModules/Documents/"
    '    Dim imgField As New ImageField()
    '    Dim url As String
    '    Dim Filename As String
    '    Filename = image_url
    '    url = folderPath & "" & Filename
    '    Image1.ImageUrl = url

    '    Dim script As String = "var popup = $('.popup');
    '                            $('body').append(popup);
    '                            popup.show();"
    '    ClientScript.RegisterStartupScript(Me.GetType(), "OpenPopupScript", script, True)

    '    Dim script2 As String = "
    '        var popup = $('.popup');
    '        var closeBtn = popup.find('.close-btn');
    '        closeBtn.click(function() {
    '            popup.hide();
    '        });
    '    "
    '    ClientScript.RegisterStartupScript(Me.GetType(), "ClosePopupScript", script2, True)

    'End Sub

    Protected Sub search_Click(ByVal sender As Object, ByVal e As EventArgs) Handles search.Click
        valueSearch(searchbox.Text)
    End Sub

    Protected Sub search_Click1(ByVal sender As Object, ByVal e As EventArgs) Handles viewall.Click
        valueSearch1()
    End Sub

    Private Sub valueSearch(value As String)

        dt = con.ReturnDtTable("select (select FILE_NAME from DOC_UPLOAD where DOC_type='insurance'and tran_id=insu_track.tran_id) as Receipt_img ,Cust_Name,Mobile_Number,Insurance_Amt,(select CONCAT(EMPFIRSTNAME,' ', EMPLASTNAME) AS DSE_NAME from EMPLOYEEMASTER where SRNO=dse_name) as dse_name,location,Recd_amt,Remark from insu_track  where link_status='2' and concat(location, Cust_Name,Mobile_Number) Like '%" & value & "%' ")
        Data_Grid.DataSource = dt
        Data_Grid.DataBind()
    End Sub

    Private Sub valueSearch1()
        dt = con.ReturnDtTable("select (select FILE_NAME from DOC_UPLOAD where DOC_type='insurance'and tran_id=insu_track.tran_id) as Receipt_img ,Cust_Name,Mobile_Number,Insurance_Amt,(select CONCAT(EMPFIRSTNAME,' ', EMPLASTNAME) AS DSE_NAME from EMPLOYEEMASTER where SRNO=dse_name) as dse_name,location,Recd_amt,Remark from insu_track  where link_status='2'")
        Data_Grid.DataSource = dt
        Data_Grid.DataBind()
    End Sub
End Class