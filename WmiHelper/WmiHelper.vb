'****************************************************************************************************************
'WmiHelper.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'
'Mit dieser Klasse ist es möglich verschiedene Informationen über das System zu erlangen.
'
'Zur Zeit sind folgende Funktionen enthalten:
'
'- GetMaiboradInfo - Informationen über das Mainboard
'  (Hersteller,Bezeichnung,Seriennummer,Version)
'- GetPhysikalDriveInfo - Informationen über die physikalischen Laufwerke
'  (Anzahl der Laufwerke,Modell,Interfacetyp,Anzahl der Partitionen,
'  gesamter Speicherplatz, Seriennummer)
'- GetLogigDriveInfo - Informationen über die logischen Laufwerke
'  (Anzahl der logischen Laufwerke,Laufwerksbezeichnung,Kompression,Laufwerksart,
'  Art des Dateisystems,freier Speicherplatz,Netzwerkpfad,Speicherplatz,
'  Volumenbezeichnung, Seriennummer)
'- GetSystemInfo - Informationen über das Betriebssystem
'  (Name des betriebssystems,Version,Buildnummer,Seriennummer,Architektur)
'
'Verwendung
'
'Objektvariable
'Dim wmh As New SchlumpfSoft.WmiHelper
'
'Information erlangen
'Dim Info As String = wmh.GetFunktionsname(SchlumpfSoft.WmiHelper.InfoTyp)
'
'Hinweis
'Bei den Funktionen über Laufwerke kann noch der Index des Laufwerkes angegeben werden.
'(Ohne Index werden die informationen zum 1. Laufwerk ermittelt)
'
'Literaturnachweise
'- Seriennummer eines Datenträgers auslesen (Microsoft Community)
'  https://social.msdn.microsoft.com/Forums/de-DE/488b2910-03bd-4d4c-a532-09d8f74de207/seriennummer-eines-datentrgers-auslesen?forum=vbasicexpresseditionde#488b2910-03bd-4d4c-a532-09d8f74de207
'- Seriennummer eines Laufwerkes auslesen mit WMI (DotNet Snippetds.de)
'  https://dotnet-snippets.de/snippet/seriennummer-eines-laufwerkes-auslesen-mit-wmi/805
'
'****************************************************************************************************************

Namespace SchlumpfSoft


    ''' <summary>
    ''' Mit dieser Klasse ist es möglich verschiedene Informationen per WMI zu ermitteln.
    ''' </summary>
    Public Class WmiHelper


#Region "Enums"

        ''' <summary>
        ''' Auflistung der Mainboardinformationen die abgerufen werden können.
        ''' </summary>
        Public Enum BoardInfo

            ''' <summary>
            ''' Name des Herstellers.
            ''' </summary>
            Manufacturer = 0

            ''' <summary>
            ''' Bezeichnung des Mainboards
            ''' </summary>
            Product = 1

            ''' <summary>
            ''' Seriennummer des Mainboards
            ''' </summary>
            SerialNumber = 2

            ''' <summary>
            ''' Version des Mainboards
            ''' </summary>
            Version = 3

        End Enum

        ''' <summary>
        ''' Auflistung der Laufwerksinformationen eines logischen Laufwers die abgerufen werden können.
        ''' </summary>
        Public Enum LogigDriveInfo

            ''' <summary>
            ''' Anzahl der Logischen Laufwerke
            ''' </summary>
            Count = 0

            ''' <summary>
            ''' Laufwerksbezeichnung
            ''' </summary>
            Name = 1

            ''' <summary>
            ''' Kompression
            ''' </summary>
            Compressed = 2

            ''' <summary>
            ''' Laufwerksart
            ''' </summary>
            Discreption = 3

            ''' <summary>
            ''' Art des Dateisystems
            ''' </summary>
            Filesystem = 4

            ''' <summary>
            ''' freier Speicherplatz
            ''' </summary>
            Freespace = 5

            ''' <summary>
            ''' Netzwerkpfad
            ''' </summary>
            Providername = 6

            ''' <summary>
            ''' Speicherplatz
            ''' </summary>
            Size = 7

            ''' <summary>
            ''' Volumebezeichnung
            ''' </summary>
            Volumename = 8

            ''' <summary>
            ''' Seriennummer
            ''' </summary>
            Volumeserialnumber = 9

        End Enum

        ''' <summary>
        ''' Auflistung der Laufwerksinformationen eines physikalischen Laufwers die abgerufen werden können.
        ''' </summary>
        Public Enum PhysicalDriveInfo

            ''' <summary>
            ''' Anzahl der physikalischen Laufwerke
            ''' </summary>
            Count = 0

            ''' <summary>
            ''' Modelname des physikalischen Laufwerks
            ''' </summary>
            Model = 1

            ''' <summary>
            ''' Interfacetyp des physikalischen Laufwerks
            ''' </summary>
            InterfaceType = 2

            ''' <summary>
            ''' Anzahl der Partitionen des physikalischen Laufwerks
            ''' </summary>
            Partitions = 3

            ''' <summary>
            ''' Gesamter Speicherplatz des physikalischen Laufwerks in Byte
            ''' </summary>
            Size = 4

            ''' <summary>
            ''' Seriennummer des physikalischen Laufwerks
            ''' </summary>
            Serialnumber = 5

        End Enum

        ''' <summary>
        ''' Auflistung der Betriebssysteminformationen die abgerufen werden können.
        ''' </summary>
        Public Enum SystemInfo

            ''' <summary>
            ''' Name des Betriebssystems
            ''' </summary>
            Name = 0

            ''' <summary>
            ''' Version des Betriebssystems
            ''' </summary>
            Version = 1

            ''' <summary>
            ''' Buildnummer des Betriebssystems
            ''' </summary>
            BuildNumber = 2

            ''' <summary>
            ''' Seriennummer des Betriebssystems
            ''' </summary>
            SerialNumber = 3

            ''' <summary>
            ''' Architektur des Betriebssystems
            ''' </summary>
            Architecture = 4

        End Enum

#End Region


#Region "Public Methods"

        ''' <summary>
        ''' Gibt Informationen zu einem logischen Laufwerk zurück.
        ''' </summary>
        ''' <param name="Info">Art der Information die zurückgegeben werden soll.</param>
        ''' <param name="Index">
        ''' Index des logischen Lauwerks zu dem die Informationen zurückgegeben werden sollen.
        ''' </param>
        ''' <returns>
        ''' Die abgefragte Information als String.
        ''' </returns>
        Public Function GetLogigDriveInfo(Info As LogigDriveInfo, Optional Index As Integer = 0) As String

            Dim result As String = String.Empty
            Dim querystring As String = "SELECT * FROM Win32_LogicalDisk"
            Dim obj As System.Management.ManagementObject = SetManagmentObject(Index, querystring)

            Select Case Info

                'Anzahl der physikalichen Laufwerke
                Case LogigDriveInfo.Count : result = GetSearcherCount(querystring)

                'Name des Laufwerks
                Case LogigDriveInfo.Name : result = GetPropertyResult(obj.GetPropertyValue("Name"))

                'Kompression
                Case LogigDriveInfo.Compressed : result = GetPropertyResult(obj.GetPropertyValue("Compressed"))

                'Laufwerksart
                Case LogigDriveInfo.Discreption : result = GetPropertyResult(obj.GetPropertyValue("Description"))

                'Dateisystem
                Case LogigDriveInfo.Filesystem : result = GetPropertyResult(obj.GetPropertyValue("FileSystem"))

                'freier Speicherplatz
                Case LogigDriveInfo.Freespace : result = GetPropertyResult(obj.GetPropertyValue("FreeSpace"))

                'Netzwerkpfad
                Case LogigDriveInfo.Providername : result = GetPropertyResult(obj.GetPropertyValue("ProviderName"))

                'gesamter Speicherplatz
                Case LogigDriveInfo.Size : result = GetPropertyResult(obj.GetPropertyValue("Size"))

                'Volumebezeichnung
                Case LogigDriveInfo.Volumename : result = GetPropertyResult(obj.GetPropertyValue("VolumeName"))

                'Seriennummer
                Case LogigDriveInfo.Volumeserialnumber : result = GetPropertyResult(obj.GetPropertyValue("VolumeSerialNumber"))

            End Select

            Return result

        End Function

        ''' <summary>
        ''' Gibt Informationen zur Hauptplatine zurück.
        ''' </summary>
        ''' <param name="Info">
        ''' Art der Information die zuückgegeben werden soll.
        ''' </param>
        ''' <returns>
        ''' Die abgefragten Informationen als String.
        ''' </returns>
        Public Function GetMainboardInfo(Info As BoardInfo) As String

            Dim result As String = String.Empty
            Dim obj As System.Management.ManagementObject = SetManagmentObject(0, "SELECT * FROM Win32_BaseBoard")

            Select Case Info

                'Mainboardhersteller
                Case BoardInfo.Manufacturer : result = GetPropertyResult(obj.GetPropertyValue("Manufacturer"))

                'Mainboardbezeichnung
                Case BoardInfo.Product : result = GetPropertyResult(obj.GetPropertyValue("Product"))

                'Seriennummer
                Case BoardInfo.SerialNumber : result = GetPropertyResult(obj.GetPropertyValue("SerialNumber"))

                'Mainboardversion
                Case BoardInfo.Version : result = GetPropertyResult(obj.GetPropertyValue("Version"))

            End Select

            Return result

        End Function

        ''' <summary>
        ''' Gibt Informationen zu einem physikalischem Laufwerk zurück.
        ''' </summary>
        ''' <param name="Info">
        ''' Art der Information die zurückgegeben werden soll.
        ''' </param>
        ''' <param name="Index">
        ''' Index des physikalischen Lauwerks zu dem die Informationen zurückgegeben werden sollen.
        ''' </param>
        ''' <returns>
        ''' Die abgefragte Information als String.
        ''' </returns>
        Public Function GetPhysicalDriveInfo(Info As PhysicalDriveInfo, Optional Index As Integer = 0) As String

            Dim result As String = String.Empty
            Dim querystring As String = "SELECT * FROM Win32_DiskDrive"
            Dim obj As System.Management.ManagementObject = SetManagmentObject(Index, querystring)

            Select Case Info

                'Anzahl der physikalichen Laufwerke
                Case PhysicalDriveInfo.Count : result = GetSearcherCount(querystring)

                'Modelname des physikalischen Laufwerks
                Case PhysicalDriveInfo.Model : result = GetPropertyResult(obj.GetPropertyValue("Model"))

                'Interfacetyp des physikalischen Laufwers
                Case PhysicalDriveInfo.InterfaceType : result = GetPropertyResult(obj.GetPropertyValue("InterfaceType"))

                'Patitionen des physikalichen Laufwers
                Case PhysicalDriveInfo.Partitions : result = GetPropertyResult(obj.GetPropertyValue("Partitions"))

                'Speicherplatz des physikalischen Laufwerks
                Case PhysicalDriveInfo.Size : result = GetPropertyResult(obj.GetPropertyValue("Size"))

                'Seriennummer des physikalischen Laufwerks
                Case PhysicalDriveInfo.Serialnumber : result = GetPropertyResult(obj.GetPropertyValue("SerialNumber"))

            End Select

            Return result

        End Function

        ''' <summary>
        ''' Gibt Informationen über das Betriebssystem zurück.
        ''' </summary>
        ''' <param name="Info">
        ''' Die Art der Information die Zurückgegeben werden soll.
        ''' </param>
        ''' <returns>
        ''' Die angeforderte Information als String.
        ''' </returns>
        Public Function GetSystemInfo(Info As SystemInfo) As String

            Dim result As String = String.Empty
            Dim obj As System.Management.ManagementObject = SetManagmentObject(0, "SELECT * FROM Win32_OperatingSystem")

            Select Case Info

                    'Name des Betriebssystems
                Case SystemInfo.Name : result = GetPropertyResult(obj.GetPropertyValue("Caption"))

                    'Version des Betriebssystems
                Case SystemInfo.Version : result = GetPropertyResult(obj.GetPropertyValue("Version"))

                    'Buildnummer des Betriebssystems
                Case SystemInfo.BuildNumber : result = GetPropertyResult(obj.GetPropertyValue("BuildNumber"))

                    'Seriennummer des Betriebssystems
                Case SystemInfo.SerialNumber : result = GetPropertyResult(obj.GetPropertyValue("SerialNumber"))

                    'Architektur des Betriebssystems
                Case SystemInfo.Architecture : result = GetPropertyResult(obj.GetPropertyValue("OSArchitecture"))

            End Select

            Return result

        End Function

#End Region


#Region "Private Methods"

        Private Function GetPropertyResult([Property] As Object) As String

            Dim result = If(IsNothing([Property]), "", [Property].ToString)
            Return result

        End Function

        Private Function GetSearcherCount(QueryString As String) As String

            Dim searcher As New System.Management.ManagementObjectSearcher("root\CIMV2", QueryString)
            Return searcher.Get().Count.ToString

        End Function

        Private Function SetManagmentObject(Index As Integer, QueryString As String) As System.Management.ManagementObject

            Dim searcher As New System.Management.ManagementObjectSearcher("root\CIMV2", QueryString)
            Dim result As System.Management.ManagementObject = Nothing
            Dim i As Integer = 0
            For Each obj As System.Management.ManagementObject In searcher.Get()
                If i = Index Then
                    result = obj
                    Exit For
                End If
                i += 1
            Next
            Return result

        End Function

#End Region


    End Class


End Namespace