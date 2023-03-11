'
'****************************************************************************************************************
'Base64Helper.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'
'Eine Klasse zum Codieren und Decodieren von Text, Bildern und beliebigen Dateien In Base64-Code und zurück.
'
'z.Zt.sind folgende Funktionen enthalten: 
'
'- StringToBase64 - Text in Base64 konvertieren.
'- StringFromBase64 - Base64 - Code in Text konvertieren.
'- ImageToBase64 - Bild in Base64 konvertieren.
'- ImageToHtml - Bild in HTML - Code konvertieren (<img ... />).
'- ImageFromBase64 - Base64 - Code in Bild konvertieren.
'- FileToBase64 - Beliebige Datei in Base64 konvertieren.
'- FileFromBase64 - Base64 - Code in beliebige Datei konvertieren.
'
'Verwendung:
'
'Objektvariable erstellen
'Private b64 As New SchlumpfSoft.Base64Helper
'
'Text codieren
'Dim B64Code As String = b64.StringToBase64(InputText As String)
'
'Text decodieren
'Dim OutputText As String = b64.StringFromBase64(Base64Code As String)
'
'Bild als base64code codieren
'Dim B64Code As String = b64.ImageToBase64(InputImage As Image)
'
'Bild als HTMLcode codieren
'Dim HtmlCode as String = b64.ImageToHtml(InputImage as Image)
'
'Bild decodieren
'Dim OutputImage As Image = b64.ImageFromBase64(Base64Code As String)
'
'beliebige Datei codieren
'Dim B64Code As String = b64.FileToBase64(InputFileName As String)
'
'beliebige Datei decodieren
'b64.FileFromBase64(Base64Code as String,OutputFileName as String)
'
'Literaturnachweise:
'
'- Base64-Codierung
'  https://www.vbarchiv.net/tipps/tipp_1491-base64-codierung-vbnet.html
'- Convert.ToBase64String Methode
'  https://learn.microsoft.com/de-de/dotnet/api/system.convert.tobase64string?view=netframework-3.5
'- Convert.FromBase64String(String) Methode
'  https://learn.microsoft.com/de-de/dotnet/api/system.convert.frombase64string?view=netframework-3.5
'
'****************************************************************************************************************

Namespace SchlumpfSoft

	Public Class Base64Helper


#Region "Fields"

		Private Const FILENOTFOUNDEXEPTIOMESSAGE = "Die Datei ""{0}"" wurde nicht gefunden."
		Private Const HTMLCODE = "<img width='{0}' height='{1}' src='data:image;base64,{2}' alt='' />"
		Private Const IOEXEPTIONMESSAGE = "Die Datei ""{0}"" kann nicht überschrieben werden."
		Private Const ISNULLOREMPTYEXEPTIONMESSAGE = "Das Argument ""{0}"" darf nicht leer oder NULL sein."

#End Region

#Region "Public Methods"

		''' <summary>
		''' Konvertiert einen Base64-Datenstring in eine beliebige Datei.
		''' </summary>
		''' <param name="Base64Data">
		''' Base64-Datenstring.
		''' </param>
		''' <param name="FilePath">
		''' Pfad und Name der Datei die erstellt werden soll.
		''' </param>
		''' <param name="Overwrite">
		''' Überschreiben einer eventuell existierenden Datei.
		''' </param>
		''' <exception cref="ArgumentException">
		''' Wird erzeugt wenn einer der Parameter <paramref name="Base64Data"/> oder <paramref name="FilePath"/> Null oder leer ist.
		''' </exception>
		''' <exception cref="IO.IOException">
		''' Wird erzeugt wenn der Parameter <paramref name="Overwrite"/> False ist und die 
		''' im Parameter <paramref name="FilePath"/> angegebene Datei bereits existiert.
		''' </exception>
		Public Sub FileFromBase64(Base64Data As String, FilePath As String, Optional Overwrite As Boolean = False)

			'Fehler erzeugen wenn der Parameter Base64Data keinen Wert enthält
			If String.IsNullOrEmpty(Base64Data) Then
				Throw New ArgumentException(String.Format(ISNULLOREMPTYEXEPTIONMESSAGE, NameOf(Base64Data))) : Exit Sub
			End If

			'Fehler erzeugen wenn der Parameter FilePath keinen Wert enthält
			If String.IsNullOrEmpty(FilePath) Then
				Throw New ArgumentException(String.Format(ISNULLOREMPTYEXEPTIONMESSAGE, NameOf(FilePath))) : Exit Sub
			End If

			'Fehler erzeugen wenn die Datei existiert und überschreiben nicht aktiviert ist
			If Not Overwrite And IO.File.Exists(FilePath) Then
				Throw New IO.IOException(String.Format(IOEXEPTIONMESSAGE, FilePath)) : Exit Sub
			End If

			'String decodieren und in Byte-Array umwandeln
			Dim bytes() As Byte = Convert.FromBase64String(Base64Data)

			'Datei schreiben
			IO.File.WriteAllBytes(FilePath, bytes)

		End Sub

		''' <summary>
		''' Konvertiert eine beliebige Datei <paramref name="FilePath"/> in Base64-Code.
		''' </summary>
		''' <param name="FilePath">
		''' Pfad und Name der Datei die codiert werden soll.
		''' </param>
		''' <returns>
		''' Base64 codierter String.
		''' </returns>
		''' <exception cref="ArgumentException">
		''' Wird erzeugt wenn der Parameter <paramref name="FilePath"/> nicht existiert.
		''' </exception>
		Public Function FileToBase64(FilePath As String) As String

			'Fehler erzeugen wenn der Parameter "FilePath" keinen Wert enthält
			If String.IsNullOrEmpty(FilePath) Then
				Throw New ArgumentException(String.Format(ISNULLOREMPTYEXEPTIONMESSAGE, NameOf(FilePath))) : Exit Function
			End If

			'Fehler erzeugen wenn die Datei FilePath nicht existiert
			If Not IO.File.Exists(FilePath) Then
				Throw New IO.FileNotFoundException(String.Format(FILENOTFOUNDEXEPTIOMESSAGE, FilePath)) : Exit Function
			End If

			'Datei in Byte-Array einlesen
			Dim bytes As Byte() = IO.File.ReadAllBytes(FilePath)

			'Byte-Array in Base64-codierten String umwandeln und Datenstring zurückgeben
			Return Convert.ToBase64String(bytes, Base64FormattingOptions.InsertLineBreaks)

		End Function

		''' <summary>
		''' Konvertiert einen Base64-codierten String in ein Image-Objekt.
		''' </summary>
		''' <param name="Base64Data">
		''' Base64-codierter String.
		''' </param>
		''' <returns>
		''' Das Erzeugte Image.
		''' </returns>
		''' <exception cref="ArgumentException">
		''' Wird erzeugt wenn der Parameter <paramref name="Base64Data"/> leer ist.
		''' </exception>
		Public Function ImageFromBase64(Base64Data As String) As System.Drawing.Image

			'Fehler erzeugen wenn der Parameter Base64Data keinen Wert enthält.
			If String.IsNullOrEmpty(Base64Data) Then
				Throw New ArgumentException(String.Format(ISNULLOREMPTYEXEPTIONMESSAGE, NameOf(Base64Data))) : Exit Function
			End If

			Dim ic As New System.Drawing.ImageConverter

			'String decodieren und in Byte-Array umwandeln
			Dim bytes() As Byte = Convert.FromBase64String(Base64Data)

			'Byte-Array in Image-Objekt umwandeln und das Image-Objekt zurückgeben 
			Return CType(ic.ConvertFrom(bytes), System.Drawing.Image)

		End Function

		''' <summary>
		''' Konvertiert ein Image in einen Base64-codierten Datenstring.
		''' </summary>
		''' <param name="[Image]">
		''' Image das codiert werden soll.
		''' </param>
		''' <returns>
		''' Konvertierter Datenstring.
		''' </returns>
		''' <exception cref="ArgumentException">
		''' Wird erzeugt wenn der Parameter <paramref name="[Image]"/> leer ist.
		''' </exception>
		Public Function ImageToBase64([Image] As System.Drawing.Image) As String

			'Fehler erzeugen wenn der Parameter Image leer ist
			If [Image] Is Nothing Then
				Throw New ArgumentException(String.Format(ISNULLOREMPTYEXEPTIONMESSAGE, NameOf([Image]))) : Exit Function
			End If

			Dim ic As New System.Drawing.ImageConverter

			'Image in Byte-Array umwandeln
			Dim bytes() As Byte = CType(ic.ConvertTo([Image], GetType(Byte())), Byte())

			'Byte-Array in Base64-codierten String umwandeln	und Datenstring zurückgeben
			Return Convert.ToBase64String(bytes, Base64FormattingOptions.InsertLineBreaks)

		End Function

		''' <summary>
		''' Konvertiert ein Bild in HTML-Code
		''' </summary>
		''' <param name="[Image]">
		''' Bild welches konvertiert werden soll.
		''' </param>
		''' <param name="RelSize">
		''' Relative Bildgröße in Prozent vom Original.
		''' </param>
		''' <returns>
		''' Der erzeugte HTML-Code.
		''' </returns>
		''' <exception cref="ArgumentException">
		''' Wird erzeugt wenn der Parameter <paramref name="[Image]"/> leer ist.
		''' </exception>
		Public Function ImageToHtml([Image] As System.Drawing.Image, Optional RelSize As Integer = 100) As String

			'Fehler erzeugen wenn der Parameter Image leer ist
			If [Image] Is Nothing Then
				Throw New ArgumentException(String.Format(ISNULLOREMPTYEXEPTIONMESSAGE, NameOf([Image]))) : Exit Function
			End If

			'Base64 - Code erzeugen
			Dim c As String = ImageToBase64([Image])

			'Bildgröße anpassen
			Dim w As Integer = CInt([Image].Width / 100 * RelSize)
			Dim h As Integer = CInt([Image].Height / 100 * RelSize)

			'Ergebnis zurück
			Return String.Format(HTMLCODE, CStr(w), CStr(h), c)

		End Function

		''' <summary>
		''' Konvertiert einen Base64-codierten Datenstring <paramref name="Base64Data"/> in einen lesbaren String.
		''' </summary>
		''' <param name="Base64Data">
		''' Der zu konvertierende Datenstring.
		''' </param>
		''' <returns>
		''' Lesbarer String.
		''' </returns>
		''' <exception cref="ArgumentException">
		''' Wird erzeugt wenn der Parameter <paramref name="Base64Data"/> leer ist oder der ungültige Daten enthält.
		''' </exception>
		Public Function StringFromBase64(Base64Data As String) As String

			'Fehler erzeugen wenn der Parameter Data leer ist
			If String.IsNullOrEmpty(Base64Data) Then
				Throw New ArgumentException(String.Format(ISNULLOREMPTYEXEPTIONMESSAGE, NameOf(Base64Data))) : Exit Function
			End If

			'Base64-String zunächst in ByteArray konvertieren
			Dim bytes() As Byte = Convert.FromBase64String(Base64Data)

			'ByteArray in String umwandeln und Textstring zurückgeben
			Return Text.Encoding.Default.GetString(bytes)

		End Function

		''' <summary>
		''' Konvertiert einen String <paramref name="String"/> in einen Base64-codierten Datenstring.
		''' </summary>
		''' <param name="String">
		''' Textstring der konvertiert werden soll.
		''' </param>
		''' <returns>
		''' Base64-codierter String.
		''' </returns>
		''' <exception cref="ArgumentException">
		''' Wird erzeugt wenn der Parameter <paramref name="[String]"/> leer ist.
		''' </exception>
		Public Function StringToBase64([String] As String) As String

			'Fehler erzeugen wenn der Parameter String leer ist
			If String.IsNullOrEmpty([String]) Then
				Throw New ArgumentException(String.Format(ISNULLOREMPTYEXEPTIONMESSAGE, NameOf([String]))) : Exit Function
			End If

			'String zunächst in ein Byte-Array umwandeln
			Dim bytes() As Byte = Text.Encoding.Default.GetBytes([String])

			'jetzt das Byte-Array nach Base64 codieren	und Wert zurück
			Return Convert.ToBase64String(bytes)

		End Function

#End Region

	End Class

End Namespace
