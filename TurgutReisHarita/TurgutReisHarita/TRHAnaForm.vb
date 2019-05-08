Imports GMap.NET
Imports GMap.NET.MapProviders
Imports GMap.NET.WindowsForms
Public Class TRHAnaForm
    Private MarkerKatman As New GMapOverlay()
    Private YolTarifiKatman As New GMapOverlay()
    Private Sub TRHAnaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HaritaEkle()
        TRHGMap.Position = New PointLatLng(37.208621, 28.3695595)
        TRHGMap.Refresh()
        ZoomNUD.Value = 18
    End Sub
    Private Sub HaritaEkle()
        HaritaComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        Dim Haritalar As New Dictionary(Of String, Guid)
        For Each Harita As GMapProvider In GMapProviders.List
            Haritalar.Add(Harita.Name, Harita.Id)
        Next
        HaritaComboBox.DisplayMember = "Key"
        HaritaComboBox.ValueMember = "Value"
        HaritaComboBox.DataSource = New BindingSource(Haritalar, Nothing)
        HaritaComboBox.SelectedValue = GoogleMapProvider.Instance.Id
    End Sub

    Private Sub HaritaComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles HaritaComboBox.SelectedValueChanged
        Dim Harita_id As Guid = HaritaComboBox.SelectedValue
        TRHGMap.MapProvider = GMapProviders.TryGetProvider(Harita_id)
    End Sub

    Private Sub TRHGMap_OnMapTypeChanged(type As GMapProvider) Handles TRHGMap.OnMapTypeChanged
        If HaritaComboBox.SelectedIndex > -1 Then
            Dim Harita_id As Guid = HaritaComboBox.SelectedValue
            Dim Harita As GMapProvider = GMapProviders.TryGetProvider(Harita_id)
            If Harita.MaxZoom IsNot Nothing Then TRHGMap.MaxZoom = Harita.MaxZoom Else TRHGMap.MaxZoom = 25
            TRHGMap.MinZoom = Harita.MinZoom
            ZoomNUD.Maximum = TRHGMap.MaxZoom
            ZoomNUD.Minimum = TRHGMap.MinZoom
        End If
    End Sub

    Private Sub ZoomNUD_ValueChanged(sender As Object, e As EventArgs) Handles ZoomNUD.ValueChanged
        TRHGMap.Zoom = ZoomNUD.Value
    End Sub

    Private Sub TRHGMap_OnMapZoomChanged() Handles TRHGMap.OnMapZoomChanged
        ZoomNUD.Value = TRHGMap.Zoom
    End Sub

    Private Sub AdresAraButton_Click(sender As Object, e As EventArgs) Handles AdresAraButton.Click
        If TRHGMap.MapProvider.Id <> GMapProviders.OpenStreetMap.Id Then
            Dim Mesaj As String = "Adres arama işlemi için Open Street Map haritasını kullamalısınız. Haritayı değiştirmek istermisiniz?"
            If MessageBox.Show(Mesaj, "Adres Arama", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                HaritaComboBox.SelectedValue = GMapProviders.OpenStreetMap.Id
            End If
        End If
        If TRHGMap.MapProvider.Id = GMapProviders.OpenStreetMap.Id Then

            If AdresTextBox.Text.Trim.Length > 0 Then
                Try
                    Dim Adres As String = AdresTextBox.Text.Trim
                    Dim Kod As GeoCoderStatusCode
                    Kod = TRHGMap.SetPositionByKeywords(Adres)
                    If Kod <> GeoCoderStatusCode.OK Then
                        MessageBox.Show("Adres Bulunamadı.", "Arama Hatası")
                    End If
                Catch ex As Exception
                End Try
            End If
        Else
            AdresTextBox.Clear()
        End If
    End Sub

    Private Sub KoordinataGitButton_Click(sender As Object, e As EventArgs) Handles KoordinataGitButton.Click
        If IsNumeric(EnlemTextBox.Text) And IsNumeric(BoylamTextBox.Text) Then
            Dim Enlem As Decimal = CDec(EnlemTextBox.Text)
            Dim Boylam As Decimal = CDec(BoylamTextBox.Text)
            TRHGMap.Position = New PointLatLng(Enlem, Boylam)
        Else
            MessageBox.Show("Enlem ve/veya Boylam değerleri hatalı.", "Hata")
        End If

    End Sub

    Private Sub MarkerSecButton_Click(sender As Object, e As EventArgs) Handles MarkerSecButton.Click
        If MarkerSecimiFormu.ShowDialog = DialogResult.OK Then
            MarkerCheckBox.Image = MarkerSecimiFormu.MarkerResim
        End If
    End Sub

    Private Sub TRHGMap_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TRHGMap.MouseDoubleClick
        If MarkerCheckBox.Checked Then
            Dim Koordinat As PointLatLng = TRHGMap.FromLocalToLatLng(e.X, e.Y)
            Dim isaretci As GMapMarker
            isaretci = New Markers.GMarkerGoogle(Koordinat, MarkerCheckBox.Image)
            Try
                Dim Kod As GeoCoderStatusCode
                Dim Adres As Placemark = GMapProviders.OpenStreetMap.GetPlacemark(Koordinat, Kod)
                If Kod = GeoCoderStatusCode.OK Then
                    isaretci.ToolTipText = Adres.Address
                End If
            Catch ex As Exception
            End Try
            MarkerKatman.Markers.Add(isaretci)
            TRHGMap.Overlays.Add(MarkerKatman)
            TRHGMap.UpdateMarkerLocalPosition(isaretci)
            TRHGMap.Refresh()
        End If
    End Sub

    Private Sub MarkerTemizleButton_Click(sender As Object, e As EventArgs)
        MarkerKatman.Markers.Clear()
        TRHGMap.Overlays.Add(MarkerKatman)
        TRHGMap.Refresh()
    End Sub

    Private Sub YolTarifiAlButton_Click(sender As Object, e As EventArgs) Handles YolTarifiAlButton.Click
        If TRHGMap.MapProvider.Id <> GMapProviders.OpenStreetMap.Id Then
            Dim Mesaj As String = "Yol tarifi işlemi için Open Street Map haritasını kullamalısınız. Haritayı değiştirmek istermisiniz?"
            If MessageBox.Show(Mesaj, "Yol Tarifi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                HaritaComboBox.SelectedValue = GMapProviders.OpenStreetMap.Id
            End If
        End If
        If TRHGMap.MapProvider.Id = GMapProviders.OpenStreetMap.Id Then

            If NeredenTextBox.Text.Trim.Length > 0 And NereyeTextBox.Text.Trim.Length > 0 Then
                Dim Nereden As String = NeredenTextBox.Text.Trim
                Dim Nereye As String = NereyeTextBox.Text.Trim
                Try
                    YolTarifiKatman.Clear()
                    Dim YolTarifi As MapRoute
                    Dim NeredenPos As PointLatLng
                    TRHGMap.GetPositionByKeywords(Nereden, NeredenPos)
                    Dim NereyePos As PointLatLng
                    TRHGMap.GetPositionByKeywords(Nereye, NereyePos)
                    YolTarifi = GMapProviders.OpenStreetMap.GetRoute(NeredenPos, NereyePos, False, False, ZoomNUD.Value)
                    Dim Yol As New GMapRoute(YolTarifi)
                    Yol.Stroke.Color = Color.DarkRed
                    Yol.Stroke.Width = 2
                    YolTarifiKatman.Routes.Add(Yol)
                    TRHGMap.Overlays.Add(YolTarifiKatman)
                    TRHGMap.UpdateRouteLocalPosition(Yol)
                    TRHGMap.Refresh()
                Catch ex As Exception
                    MessageBox.Show("Yol Tarifi bulunamadı.", "Yol tarifi")
                End Try
            End If
        End If
    End Sub
End Class
