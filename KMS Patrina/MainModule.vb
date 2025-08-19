Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Module MainModule

    Public ReadOnly SPP_RSA_KEY_PRODUCTION() As Byte = {&H7, &H2, &H0, &H0, &H0, &HA4, &H0, &H0, &H52, &H53, &H41, &H32, &H0, &H4, &H0, &H0, &H1, &H0, &H1, &H0, &H29, &H87, &HBA, &H3F, &H52, &H90, &H57, &HD8, &H12, &H26, &H6B, &H38, &HB2, &H3B, &HF9, &H67, &H8, &H4F, &HDD, &H8B, &HF5, &HE3, &H11, &HB8, &H61, &H3A, &H33, &H42, &H51, &H65, &H5, &H86, &H1E, &H0, &H41, &HDE, &HC5, &HDD, &H44, &H60, &H56, &H3D, &H14, &H39, &HB7, &H43, &H65, &HE9, &HF7, &H2B, &HA5, &HF0, &HA3, &H65, &H68, &HE9, &HE4, &H8B, &H5C, &H3, &H2D, &H36, &HFE, &H28, &H4C, &HD1, &H3C, &H3D, &HC1, &H90, &H75, &HF9, &H6E, &H2, &HE0, &H58, &H97, &H6A, &HCA, &H80, &H2, &H42, &H3F, &H6C, &H15, &H85, &H4D, &H83, &H23, &H6A, &H95, &H9E, &H38, &H52, &H59, &H38, &H6A, &H99, &HF0, &HB5, &HCD, &H53, &H7E, &H8, &H7C, &HB5, &H51, &HD3, &H8F, &HA3, &HD, &HA0, &HFA, &H8D, &H87, &H3C, &HFC, &H59, &H21, &HD8, &H2E, &HD9, &H97, &H8B, &H40, &H60, &HB1, &HD7, &H2B, &HA, &H6E, &H60, &HB5, &H50, &HCC, &H3C, &HB1, &H57, &HE4, &HB7, &HDC, &H5A, &H4D, &HE1, &H5C, &HE0, &H94, &H4C, &H5E, &H28, &HFF, &HFA, &H80, &H6A, &H13, &H53, &H52, &HDB, &HF3, &H4, &H92, &H43, &H38, &HB9, &H1B, &HD9, &H85, &H54, &H7B, &H14, &HC7, &H89, &H16, &H8A, &H4B, &H82, &HA1, &H8, &H2, &H99, &H23, &H48, &HDD, &H75, &H9C, &HC8, &HC1, &HCE, &HB0, &HD7, &H1B, &HD8, &HFB, &H2D, &HA7, &H2E, &H47, &HA7, &H18, &H4B, &HF6, &H29, &H69, &H44, &H30, &H33, &HBA, &HA7, &H1F, &HCE, &H96, &H9E, &H40, &HE1, &H43, &HF0, &HE0, &HD, &HA, &H32, &HB4, &HEE, &HA1, &HC3, &H5E, &H9B, &HC7, &H7F, &HF5, &H9D, &HD8, &HF2, &HF, &HD9, &H8F, &HAD, &H75, &HA, &H0, &HD5, &H25, &H43, &HF7, &HAE, &H51, &H7F, &HB7, &HDE, &HB7, &HAD, &HFB, &HCE, &H83, &HE1, &H81, &HFF, &HDD, &HA2, &H77, &HFE, &HEB, &H27, &H1F, &H10, &HFA, &H82, &H37, &HF4, &H7E, &HCC, &HE2, &HA1, &H58, &HC8, &HAF, &H1D, &H1A, &H81, &H31, &H6E, &HF4, &H8B, &H63, &H34, &HF3, &H5, &HF, &HE1, &HCC, &H15, &HDC, &HA4, &H28, &H7A, &H9E, &HEB, &H62, &HD8, &HD8, &H8C, &H85, &HD7, &H7, &H87, &H90, &H2F, &HF7, &H1C, &H56, &H85, &H2F, &HEF, &H32, &H37, &H7, &HAB, &HB0, &HE6, &HB5, &H2, &H19, &H35, &HAF, &HDB, &HD4, &HA2, &H9C, &H36, &H80, &HC6, &HDC, &H82, &H8, &HE0, &HC0, &H5F, &H3C, &H59, &HAA, &H4E, &H26, &H3, &H29, &HB3, &H62, &H58, &H41, &H59, &H3A, &H37, &H43, &H35, &HE3, &H9F, &H34, &HE2, &HA1, &H4, &H97, &H12, &H9D, &H8C, &HAD, &HF7, &HFB, &H8C, &HA1, &HA2, &HE9, &HE4, &HEF, &HD9, &HC5, &HE5, &HDF, &HE, &HBF, &H4A, &HE0, &H7A, &H1E, &H10, &H50, &H58, &H63, &H51, &HE1, &HD4, &HFE, &H57, &HB0, &H9E, &HD7, &HDA, &H8C, &HED, &H7D, &H82, &HAC, &H2F, &H25, &H58, &HA, &H58, &HE6, &HA4, &HF4, &H57, &H4B, &HA4, &H1B, &H65, &HB9, &H4A, &H87, &H46, &HEB, &H8C, &HF, &H9A, &H48, &H90, &HF9, &H9F, &H76, &H69, &H3, &H72, &H77, &HEC, &HC1, &H42, &H4C, &H87, &HDB, &HB, &H3C, &HD4, &H74, &HEF, &HE5, &H34, &HE0, &H32, &H45, &HB0, &HF8, &HAB, &HD5, &H26, &H21, &HD7, &HD2, &H98, &H54, &H8F, &H64, &H88, &H20, &H2B, &H14, &HE3, &H82, &HD5, &H2A, &H4B, &H8F, &H4E, &H35, &H20, &H82, &H7E, &H1B, &HFE, &HFA, &H2C, &H79, &H6C, &H6E, &H66, &H94, &HBB, &HA, &HEB, &HBA, &HD9, &H70, &H61, &HE9, &H47, &HB5, &H82, &HFC, &H18, &H3C, &H66, &H3A, &H9, &H2E, &H1F, &H61, &H74, &HCA, &HCB, &HF6, &H7A, &H52, &H37, &H1D, &HAC, &H8D, &H63, &H69, &H84, &H8E, &HC7, &H70, &H59, &HDD, &H2D, &H91, &H1E, &HF7, &HB1, &H56, &HED, &H7A, &H6, &H9D, &H5B, &H33, &H15, &HDD, &H31, &HD0, &HE6, &H16, &H7, &H9B, &HA5, &H94, &H6, &H7D, &HC1, &HE9, &HD6, &HC8, &HAF, &HB4, &H1E, &H2D, &H88, &H6, &HA7, &H63, &HB8, &HCF, &HC8, &HA2, &H6E, &H84, &HB3, &H8D, &HE5, &H47, &HE6, &H13, &H63, &H8E, &HD1, &H7F, &HD4, &H81, &H44, &H38, &HBF}

    Public Enum BlockType As UInteger
        NONE
        NAMED
        ATTRIBUTE
        TIMER
    End Enum

    Sub Main()
        Try
            Console.WriteLine(vbCrLf & "========== KMS Patrina ==========" & vbCrLf)
            Dim VersionStrings As String() = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString().Split(".")
            Console.WriteLine("Version: " & VersionStrings(0) & "." & VersionStrings(1) & "." & VersionStrings(2) & vbCrLf)

            Dim _loc_1 As String = Path.Combine(Directory.GetCurrentDirectory(), "product.txt")
            If Not File.Exists(_loc_1) Then
                Raise("Cannot find product description file.")
            End If

            Dim _loc_2 As List(Of String) = File.ReadAllLines(_loc_1).Select(Function(x) x.Trim()).Where(Function(x) x <> "").ToList()

            If _loc_2.Count = 0 Then
                Raise("Invalid product description file.")
            End If

            Dim _loc_3 As String = _loc_2(0)
            Dim _loc_4 As String = _loc_3

            If Not File.Exists(_loc_4) Then
                Dim _loc_5 As String = Path.Combine(Directory.GetCurrentDirectory(), _loc_3)
                If Not File.Exists(_loc_5) Then
                    Raise("Cannot find file: " & _loc_3)
                Else
                    _loc_4 = _loc_5
                End If
            End If

            Console.WriteLine("Process: " & _loc_4)
            Dim _loc_11 As Byte() = DecryptDat(My.Computer.FileSystem.ReadAllBytes(_loc_4))
            Dim _loc_12 As Byte() = _loc_11.Take(16).ToArray()
            Dim _loc_13 As Byte() = _loc_11.Skip(16).Take(20).ToArray()
            Dim _loc_14 As Byte() = _loc_11.Skip(40).ToArray()

            Console.WriteLine("HMAC-SHA1 Key: 0x" & BytesToHex(_loc_12))
            If Not HMACSHA1Verify(_loc_14, _loc_12, _loc_13) Then
                Raise("HMAC-SHA1 verification failed.")
            End If

            'DumpDat(_loc_14)

            Dim _loc_6 As New List(Of String)
            Dim _loc_21 As New List(Of String)
            For _loc_7 As Integer = 1 To _loc_2.Count - 1
                If _loc_2(_loc_7).StartsWith("[") And _loc_2(_loc_7).EndsWith("]") Then
                    _loc_21.Add(_loc_2(_loc_7).Substring(1, _loc_2(_loc_7).Length - 2).Trim())
                ElseIf _loc_2(_loc_7).Length = 36 Then
                    _loc_6.Add(_loc_2(_loc_7))
                End If
            Next
            If _loc_6.Count < 2 Then
                Raise("Cannot find product ID.")
            End If
            If _loc_6.Count Mod 2 <> 0 Then _loc_6.RemoveAt(_loc_6.Count - 1)

            Dim _loc_9 As Boolean = False
            For _loc_8 As Integer = 0 To _loc_6.Count / 2 - 1
                Dim SkuID As String = _loc_6(_loc_8 * 2 + 1)
                Dim ApplicationID As String = _loc_6(_loc_8 * 2)

                If ApplicationID.Length <> 36 Then Raise("Invalid Application ID.")
                If SkuID.Length <> 36 Then Raise("Invalid Product SKU ID.")

                Console.WriteLine()
                If _loc_21.Count - 1 >= _loc_8 Then Console.WriteLine(_loc_21(_loc_8))
                Console.WriteLine("Application ID: " & ApplicationID)
                Console.WriteLine("Product SKU ID: " & SkuID)

                Dim _loc_15 As Byte() = InsertDat(_loc_14, "SPPSVC\" & ApplicationID & "\" & SkuID, "msft:spp/kms/bind/2.0/store/" & ApplicationID & "/" & SkuID, HexToBytes("74C111DF0400000000000000040100000000060054D34008F3CD03EFC815879ECA2E85FBE6F67366FBDABB7BB1BCD6F95C41A0FEE174C4BB91E5DE6D3A11D5FC68C07B82B224D185BA45BFF126FAA5C6617069696E0F0B60B73DE8F1470B65FDA7301EF6A4D079C4588D81FDA7E753F16778F00F608FC81635229448CB0F8EB21DF73E2842556B07E3E851D5FA220C86650D3FDD8D9B1BC9D3B83AECF1111925F7844A4C0AB531943776CEE7ABA969DFA4C9226C23FF6BFCDA78D8C48F74BB260500989BE5E2AD0D579580668E437487931FF4B22C205FD89C4C56B3574462688DAA40119D84620E438A1DF01C49D856EF4CD364BA0DEF87B52C88F318FF3A8CF5A6785C62E39E4CB6312D068092BC2E92A6569600000000456E44E60200000000000000360000006D007300660074003A0072006D002F0061006C0067006F0072006900740068006D002F0068007700690064002F0034002E003000000000002CC01225040000002C00000026000000530070007000420069006E00640069006E0067004C006900630065006E007300650044006100740061000000000000002600000000001C000000000000000000000000000000000000000000000000000000010C01000000945F4C0B0200000000000000020000000000000000000000945F4C0B0200000000000000020000000000000000000000"))
                Dim _loc_16 As Byte() = InsertDat(_loc_15, "SPPSVC\" & ApplicationID & "\" & SkuID, "msft:spp/kms/bind/2.0/timer/" & ApplicationID & "/" & SkuID, HexToBytes("00000000000000000044B8DE940800000044B8DE94080000007069369C080000"))

                If _loc_16.SequenceEqual(_loc_14) Then
                    Console.WriteLine("Product status not updated.")
                Else
                    _loc_14 = _loc_16
                    Console.WriteLine("Product status updated.")
                    _loc_9 = True
                End If
            Next

            'DumpDat(_loc_14)

            If _loc_9 Then
                My.Computer.FileSystem.DeleteFile(_loc_4)
                My.Computer.FileSystem.WriteAllBytes(_loc_4, EncryptDat(_loc_14), False)
                Console.WriteLine(vbCrLf & "File has been updated.")
            Else
                Console.WriteLine(vbCrLf & "File is not touched.")
            End If

            Console.WriteLine(vbCrLf)
            Console.ReadLine()
        Catch ex As Exception
            Raise(ex.ToString())
        End Try
    End Sub

    Public Function AESDecrypt(param1 As Byte(), param2 As Byte()) As Byte()
        Dim _loc_1 As Aes = Aes.Create("AES")
        _loc_1.BlockSize = 128
        _loc_1.KeySize = 128
        _loc_1.Key = param2
        _loc_1.IV = New Byte(15) {}
        _loc_1.Mode = CipherMode.CBC
        _loc_1.Padding = PaddingMode.PKCS7
        Return _loc_1.CreateDecryptor().TransformFinalBlock(param1, 0, param1.Length)
    End Function

    Public Function AESEncrypt(param1 As Byte(), param2 As Byte()) As Byte()
        Dim _loc_1 As Aes = Aes.Create("AES")
        _loc_1.BlockSize = 128
        _loc_1.KeySize = 128
        _loc_1.Key = param2
        _loc_1.IV = New Byte(15) {}
        _loc_1.Mode = CipherMode.CBC
        _loc_1.Padding = PaddingMode.PKCS7
        Return _loc_1.CreateEncryptor().TransformFinalBlock(param1, 0, param1.Length)
    End Function

    Public Function BytesToHex(param1 As Byte()) As String
        Return BitConverter.ToString(param1).Replace("-", "").ToUpper
    End Function

    Public Function BytesToString(param1 As Byte()) As String
        Return Encoding.Unicode.GetString(param1)
    End Function

    Public Function DecryptDat(param1 As Byte()) As Byte()
        Dim _loc_1 As Byte() = SPP_RSA_KEY_PRODUCTION
        Using _loc_2 As New BinaryReader(New MemoryStream(param1))
            _loc_2.BaseStream.Seek(16, SeekOrigin.Begin)
            Dim _loc_3 As Byte() = _loc_2.ReadBytes(128)
            Dim _loc_4 As Byte() = _loc_2.ReadBytes(128)
            If Not RSAVerify(_loc_4, _loc_1, _loc_3) Then
                Raise("RSA signature verification failed.")
            End If
            Dim _loc_5 As Byte() = RSADecrypt(_loc_4, _loc_1)
            Console.WriteLine("AES-CBC Key: 0x" & BytesToHex(_loc_5))
            Dim _loc_6 As Byte() = AESDecrypt(_loc_2.ReadBytes(_loc_2.BaseStream.Length - 272), _loc_5)
            Return _loc_6
        End Using
    End Function

    Public Sub DumpDat(param1 As Byte())
        Using _loc_1 As New BinaryReader(New MemoryStream(param1))
            Dim preHeader As Byte() = _loc_1.ReadBytes(8)
            Console.WriteLine("Pre-Header: 0x" & BytesToHex(preHeader))

            Console.WriteLine("Section:")
            Dim numKeys As UInteger = _loc_1.ReadUInt32()
            Console.WriteLine("  NumKeys: " & numKeys)

            For k As UInteger = 0 To numKeys - 1
                Dim lenKeyName As UInteger = _loc_1.ReadUInt32()
                Dim keyName As String = BytesToString(_loc_1.ReadBytes(lenKeyName))
                Dim numValues As UInteger = _loc_1.ReadUInt32()
                Console.WriteLine($"  Key: {keyName}, NumValues: {numValues}")

                Dim mod4 As Integer = _loc_1.BaseStream.Position Mod 4
                If mod4 <> 0 Then _loc_1.BaseStream.Seek(4 - mod4, SeekOrigin.Current)

                For v As UInteger = 0 To numValues - 1
                    Dim blockType As BlockType = _loc_1.ReadUInt32()
                    Dim flags As UInteger = _loc_1.ReadUInt32()
                    Dim valueLen As UInteger = _loc_1.ReadUInt32()
                    Dim dataLen As UInteger = _loc_1.ReadUInt32()
                    Dim unknown As UInteger = _loc_1.ReadUInt32()
                    Dim value As Byte() = _loc_1.ReadBytes(valueLen)
                    Dim data As Byte() = _loc_1.ReadBytes(dataLen)

                    Console.WriteLine($"    Block {v + 1}: Type={blockType}, Flags={flags}, Unknown={unknown}")
                    Console.WriteLine($"      Value: {BytesToString(value)}")
                    Console.WriteLine($"      Data: {BytesToHex(data)}")

                    mod4 = CInt(_loc_1.BaseStream.Position Mod 4)
                    If mod4 <> 0 Then _loc_1.BaseStream.Seek(4 - mod4, SeekOrigin.Current)
                Next
            Next
        End Using
    End Sub

    Public Function EncryptDat(param1() As Byte) As Byte()
        Dim _loc_1 As Byte() = SPP_RSA_KEY_PRODUCTION
        Dim _loc_2 As Byte() = New Byte(15) {}
        Dim _loc_3 As Byte() = New Byte(15) {}
        Dim _loc_4 As Byte() = RSAEncrypt(_loc_2, _loc_1)
        Dim _loc_5 As Byte() = RSASign(_loc_4, _loc_1)
        Dim _loc_6 As Byte() = HMACSHA1Sign(param1, _loc_3)
        Dim _loc_7 As Byte() = {}
        _loc_7 = _loc_7.Concat(_loc_3).Concat(_loc_6).Concat(BitConverter.GetBytes(0)).Concat(param1).ToArray()
        Dim _loc_8 As Byte() = AESEncrypt(_loc_7, _loc_2)
        Using _loc_9 As New MemoryStream()
            Using _loc_10 As New BinaryWriter(_loc_9)
                _loc_10.Write(New Byte() {3})
                _loc_10.Write(New Byte(14) {})
                _loc_10.Write(_loc_5)
                _loc_10.Write(_loc_4)
                _loc_10.Write(_loc_8)
            End Using
            Return _loc_9.ToArray()
        End Using
    End Function

    Public Function HexToBytes(param1 As String) As Byte()
        Return Enumerable.Range(0, param1.Length).Where(Function(x) x Mod 2 = 0).[Select](Function(x) Convert.ToByte(param1.Substring(x, 2), 16)).ToArray()
    End Function

    Public Function HMACSHA1Sign(param1 As Byte(), param2 As Byte()) As Byte()
        Using _loc_1 As New HMACSHA1(param2)
            Return _loc_1.ComputeHash(param1)
        End Using
    End Function

    Public Function HMACSHA1Verify(param1 As Byte(), param2 As Byte(), param3 As Byte()) As Boolean
        Return param3.SequenceEqual(HMACSHA1Sign(param1, param2))
    End Function

    Public Function InsertDat(param1 As Byte(), param2 As String, param3 As String, param4 As Byte()) As Byte()
        Dim _loc_1 As New List(Of Byte)()
        Using _loc_2 As New BinaryReader(New MemoryStream(param1))
            Dim preHeader As Byte() = _loc_2.ReadBytes(8)
            _loc_1.AddRange(preHeader)
            Dim numKeys As UInteger = _loc_2.ReadUInt32()
            _loc_1.AddRange(BitConverter.GetBytes(numKeys))

            For k As UInteger = 0 To numKeys - 1
                Dim lenKeyName As UInteger = _loc_2.ReadUInt32()
                Dim keyNameBytes As Byte() = _loc_2.ReadBytes(lenKeyName)
                Dim keyName As String = System.Text.Encoding.Unicode.GetString(keyNameBytes)
                Dim numValues As UInteger = _loc_2.ReadUInt32()

                Dim mod4 As Integer = _loc_2.BaseStream.Position Mod 4
                If mod4 <> 0 Then _loc_2.BaseStream.Seek(4 - mod4, SeekOrigin.Current)

                Dim valuesList As New List(Of Byte())()
                Dim valueDeleted As Boolean = False

                For v As UInteger = 0 To numValues - 1
                    Dim blockType As UInt32 = _loc_2.ReadUInt32()
                    Dim flags As UInt32 = _loc_2.ReadUInt32()
                    Dim valueLen As UInt32 = _loc_2.ReadUInt32()
                    Dim dataLen As UInt32 = _loc_2.ReadUInt32()
                    Dim unknown As UInt32 = _loc_2.ReadUInt32()
                    Dim valueBytes As Byte() = _loc_2.ReadBytes(valueLen)
                    Dim dataBytes As Byte() = _loc_2.ReadBytes(dataLen)

                    mod4 = _loc_2.BaseStream.Position Mod 4
                    If mod4 <> 0 Then _loc_2.BaseStream.Seek(4 - mod4, SeekOrigin.Current)

                    Dim valueStr As String = System.Text.Encoding.Unicode.GetString(valueBytes)

                    If keyName.Substring(0, keyName.Length - 1) = param2 AndAlso valueStr.Substring(0, valueStr.Length - 1) = param3 Then
                        Console.WriteLine("Overwrite: " & param3)
                        valueDeleted = True
                    Else
                        Dim valueBlock As New List(Of Byte)()
                        valueBlock.AddRange(BitConverter.GetBytes(blockType))
                        valueBlock.AddRange(BitConverter.GetBytes(flags))
                        valueBlock.AddRange(BitConverter.GetBytes(valueLen))
                        valueBlock.AddRange(BitConverter.GetBytes(dataLen))
                        valueBlock.AddRange(BitConverter.GetBytes(unknown))
                        valueBlock.AddRange(valueBytes)
                        valueBlock.AddRange(dataBytes)

                        Dim pad As Integer = (4 - (valueBlock.Count Mod 4)) Mod 4
                        If pad > 0 Then valueBlock.AddRange(New Byte(pad - 1) {})
                        valuesList.Add(valueBlock.ToArray())
                    End If
                Next

                _loc_1.AddRange(BitConverter.GetBytes(lenKeyName))
                _loc_1.AddRange(keyNameBytes)

                Dim newNumValues As UInteger = numValues
                If keyName.Substring(0, keyName.Length - 1) = param2 AndAlso Not valueDeleted Then
                    newNumValues += 1
                End If
                _loc_1.AddRange(BitConverter.GetBytes(newNumValues))

                mod4 = _loc_1.Count Mod 4
                If mod4 <> 0 Then _loc_1.AddRange(New Byte(4 - mod4 - 1) {})

                For Each blk As Byte() In valuesList
                    _loc_1.AddRange(blk)
                Next

                If keyName.Substring(0, keyName.Length - 1) = param2 Then
                    Dim newValueBytes As Byte() = System.Text.Encoding.Unicode.GetBytes(param3 & ChrW(0))
                    Dim typePlaceholder As UInt32 = 0
                    Dim flagsPlaceholder As UInt32 = 0
                    Dim valueLen As UInteger = newValueBytes.Length
                    Dim dataLen As UInteger = param4.Length
                    Dim unknown As UInteger = 0

                    If param3.Contains("/store/") Then
                        typePlaceholder = 1
                        flagsPlaceholder = 1024
                    ElseIf param3.Contains("/timer/") Then
                        typePlaceholder = 3
                        flagsPlaceholder = 4
                    End If

                    _loc_1.AddRange(BitConverter.GetBytes(typePlaceholder))
                    _loc_1.AddRange(BitConverter.GetBytes(flagsPlaceholder))
                    _loc_1.AddRange(BitConverter.GetBytes(valueLen))
                    _loc_1.AddRange(BitConverter.GetBytes(dataLen))
                    _loc_1.AddRange(BitConverter.GetBytes(unknown))
                    _loc_1.AddRange(newValueBytes)
                    _loc_1.AddRange(param4)

                    mod4 = _loc_1.Count Mod 4
                    If mod4 <> 0 Then _loc_1.AddRange(New Byte(4 - mod4 - 1) {})
                End If
            Next
        End Using

        Return _loc_1.ToArray()
    End Function

    Public Sub Raise(param1 As String)
        Try
            Console.WriteLine(vbCrLf & "Error: " & param1 & vbCrLf & vbCrLf)
            Console.ReadLine()
        Catch ex As Exception

        Finally
            End
        End Try
    End Sub

    Public Function RSADecrypt(param1 As Byte(), param2 As Byte()) As Byte()
        Using _loc_1 As New RSACryptoServiceProvider()
            _loc_1.ImportCspBlob(param2)
            Return _loc_1.Decrypt(param1, False)
        End Using
    End Function

    Public Function RSAEncrypt(param1() As Byte, param2() As Byte) As Byte()
        Using _loc_1 As New RSACryptoServiceProvider()
            _loc_1.ImportCspBlob(param2)
            Return _loc_1.Encrypt(param1, False)
        End Using
    End Function

    Public Function RSASign(param1() As Byte, param2() As Byte) As Byte()
        Using _loc_1 As New RSACryptoServiceProvider()
            _loc_1.ImportCspBlob(param2)
            Dim _loc_2 As New RSAPKCS1SignatureFormatter(_loc_1)
            _loc_2.SetHashAlgorithm("SHA1")
            Dim _loc_3() As Byte
            Using _loc_4 As SHA1 = SHA1.Create()
                _loc_3 = _loc_4.ComputeHash(param1)
            End Using
            Return _loc_2.CreateSignature(_loc_3)
        End Using
    End Function

    Public Function RSAVerify(param1 As Byte(), param2 As Byte(), param3 As Byte()) As Boolean
        Using _loc_1 As New RSACryptoServiceProvider()
            _loc_1.ImportCspBlob(param2)
            Dim _loc_2 As New RSAPKCS1SignatureDeformatter(_loc_1)
            _loc_2.SetHashAlgorithm("SHA1")
            Dim _loc_3 As Byte()
            Using _loc_4 As SHA1 = SHA1.Create()
                _loc_3 = _loc_4.ComputeHash(param1)
            End Using
            Return _loc_2.VerifySignature(_loc_3, param3)
        End Using
    End Function

End Module
