namespace Slugity
{
    internal static class DiacriticalFoldingService
    {
        /// <summary>
        /// Perform diacritical folding on a string to convert accented characters
        /// and characters with diacritical marks to base latin characters.
        /// </summary>
        /// <revision date="3-Jan-07" author="Peter Ritchie">Published to MSDN Forums
        /// http://social.msdn.microsoft.com/Forums/en-US/netfxbcl/thread/a33217d3-86e6-4759-a12c-c407969e479f/</revision>
        /// <param name="source">String to fold</param>
        /// <returns>Folded string.</returns>
        internal static string FoldDiacriticals(string source)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (char letter in source)
            {
                switch (letter)
                {
                    case '\u00C0':
                        sb.Append('\u0041');
                        break; //  A › A    LATIN CAPITAL LETTER A WITH GRAVE › LATIN CAPITAL LETTER A
                    case '\u00C1':
                        sb.Append('\u0041');
                        break; //  Á › A    LATIN CAPITAL LETTER A WITH ACUTE › LATIN CAPITAL LETTER A
                    case '\u00C2':
                        sb.Append('\u0041');
                        break; //  Â › A    LATIN CAPITAL LETTER A WITH CIRCUMFLEX › LATIN CAPITAL LETTER A
                    case '\u00C3':
                        sb.Append('\u0041');
                        break; //  A › A    LATIN CAPITAL LETTER A WITH TILDE › LATIN CAPITAL LETTER A
                    case '\u00C4':
                        sb.Append('\u0041');
                        break; //  Ä › A    LATIN CAPITAL LETTER A WITH DIAERESIS › LATIN CAPITAL LETTER A
                    case '\u00C5':
                        sb.Append('\u0041');
                        break; //  A › A    LATIN CAPITAL LETTER A WITH RING ABOVE › LATIN CAPITAL LETTER A
                    case '\u0100':
                        sb.Append('\u0041');
                        break; //  A › A    LATIN CAPITAL LETTER A WITH MACRON › LATIN CAPITAL LETTER A
                    case '\u0102':
                        sb.Append('\u0041');
                        break; //  Ă › A    LATIN CAPITAL LETTER A WITH BREVE › LATIN CAPITAL LETTER A
                    case '\u0104':
                        sb.Append('\u0041');
                        break; //  Ą › A    LATIN CAPITAL LETTER A WITH OGONEK › LATIN CAPITAL LETTER A
                    case '\u01CD':
                        sb.Append('\u0041');
                        break; //  A › A    LATIN CAPITAL LETTER A WITH CARON › LATIN CAPITAL LETTER A
                    case '\u01DE':
                        sb.Append('\u0041');
                        break; //  A › A    LATIN CAPITAL LETTER A WITH DIAERESIS AND MACRON › LATIN CAPITAL LETTER A
                    case '\u01E0':
                        sb.Append('\u0041');
                        break; //  ? › A    LATIN CAPITAL LETTER A WITH DOT ABOVE AND MACRON › LATIN CAPITAL LETTER A
                    case '\u01FA':
                        sb.Append('\u0041');
                        break; //  ? › A    LATIN CAPITAL LETTER A WITH RING ABOVE AND ACUTE › LATIN CAPITAL LETTER A
                    case '\u0200':
                        sb.Append('\u0041');
                        break; //  ? › A    LATIN CAPITAL LETTER A WITH DOUBLE GRAVE › LATIN CAPITAL LETTER A
                    case '\u0202':
                        sb.Append('\u0041');
                        break; //  ? › A    LATIN CAPITAL LETTER A WITH INVERTED BREVE › LATIN CAPITAL LETTER A
                    case '\u0226':
                        sb.Append('\u0041');
                        break; //  ? › A    LATIN CAPITAL LETTER A WITH DOT ABOVE › LATIN CAPITAL LETTER A
                    case '\u1E00':
                        sb.Append('\u0041');
                        break; //  ? › A    LATIN CAPITAL LETTER A WITH RING BELOW › LATIN CAPITAL LETTER A
                    case '\u1EA0':
                        sb.Append('\u0041');
                        break; //  ? › A    LATIN CAPITAL LETTER A WITH DOT BELOW › LATIN CAPITAL LETTER A
                    case '\u1EA2':
                        sb.Append('\u0041');
                        break; //  ? › A    LATIN CAPITAL LETTER A WITH HOOK ABOVE › LATIN CAPITAL LETTER A
                    case '\u1EA4':
                        sb.Append('\u0041');
                        break; //  ? › A    LATIN CAPITAL LETTER A WITH CIRCUMFLEX AND ACUTE › LATIN CAPITAL LETTER A
                    case '\u1EA6':
                        sb.Append('\u0041');
                        break; //  ? › A    LATIN CAPITAL LETTER A WITH CIRCUMFLEX AND GRAVE › LATIN CAPITAL LETTER A
                    case '\u1EA8':
                        sb.Append('\u0041');
                        break; //  ? › A    LATIN CAPITAL LETTER A WITH CIRCUMFLEX AND HOOK ABOVE › LATIN CAPITAL LETTER A
                    case '\u1EAA':
                        sb.Append('\u0041');
                        break; //  ? › A    LATIN CAPITAL LETTER A WITH CIRCUMFLEX AND TILDE › LATIN CAPITAL LETTER A
                    case '\u1EAC':
                        sb.Append('\u0041');
                        break; //  ? › A    LATIN CAPITAL LETTER A WITH CIRCUMFLEX AND DOT BELOW › LATIN CAPITAL LETTER A
                    case '\u1EAE':
                        sb.Append('\u0041');
                        break; //  ? › A    LATIN CAPITAL LETTER A WITH BREVE AND ACUTE › LATIN CAPITAL LETTER A
                    case '\u1EB0':
                        sb.Append('\u0041');
                        break; //  ? › A    LATIN CAPITAL LETTER A WITH BREVE AND GRAVE › LATIN CAPITAL LETTER A
                    case '\u1EB2':
                        sb.Append('\u0041');
                        break; //  ? › A    LATIN CAPITAL LETTER A WITH BREVE AND HOOK ABOVE › LATIN CAPITAL LETTER A
                    case '\u1EB4':
                        sb.Append('\u0041');
                        break; //  ? › A    LATIN CAPITAL LETTER A WITH BREVE AND TILDE › LATIN CAPITAL LETTER A
                    case '\u1EB6':
                        sb.Append('\u0041');
                        break; //  ? › A    LATIN CAPITAL LETTER A WITH BREVE AND DOT BELOW › LATIN CAPITAL LETTER A
                    case '\u0181':
                        sb.Append('\u0042');
                        break; //  ? › B    LATIN CAPITAL LETTER B WITH HOOK › LATIN CAPITAL LETTER B
                    case '\u0182':
                        sb.Append('\u0042');
                        break; //  ? › B    LATIN CAPITAL LETTER B WITH TOPBAR › LATIN CAPITAL LETTER B
                    case '\u1E02':
                        sb.Append('\u0042');
                        break; //  ? › B    LATIN CAPITAL LETTER B WITH DOT ABOVE › LATIN CAPITAL LETTER B
                    case '\u1E04':
                        sb.Append('\u0042');
                        break; //  ? › B    LATIN CAPITAL LETTER B WITH DOT BELOW › LATIN CAPITAL LETTER B
                    case '\u1E06':
                        sb.Append('\u0042');
                        break; //  ? › B    LATIN CAPITAL LETTER B WITH LINE BELOW › LATIN CAPITAL LETTER B
                    case '\u00C7':
                        sb.Append('\u0043');
                        break; //  Ç › C    LATIN CAPITAL LETTER C WITH CEDILLA › LATIN CAPITAL LETTER C
                    case '\u0106':
                        sb.Append('\u0043');
                        break; //  Ć › C    LATIN CAPITAL LETTER C WITH ACUTE › LATIN CAPITAL LETTER C
                    case '\u0108':
                        sb.Append('\u0043');
                        break; //  C › C    LATIN CAPITAL LETTER C WITH CIRCUMFLEX › LATIN CAPITAL LETTER C
                    case '\u010A':
                        sb.Append('\u0043');
                        break; //  C › C    LATIN CAPITAL LETTER C WITH DOT ABOVE › LATIN CAPITAL LETTER C
                    case '\u010C':
                        sb.Append('\u0043');
                        break; //  Č › C    LATIN CAPITAL LETTER C WITH CARON › LATIN CAPITAL LETTER C
                    case '\u0187':
                        sb.Append('\u0043');
                        break; //  ? › C    LATIN CAPITAL LETTER C WITH HOOK › LATIN CAPITAL LETTER C
                    case '\u1E08':
                        sb.Append('\u0043');
                        break; //  ? › C    LATIN CAPITAL LETTER C WITH CEDILLA AND ACUTE › LATIN CAPITAL LETTER C
                    case '\u010E':
                        sb.Append('\u0044');
                        break; //  Ď › D    LATIN CAPITAL LETTER D WITH CARON › LATIN CAPITAL LETTER D
                    case '\u0110':
                        sb.Append('\u0044');
                        break; //  Đ › D    LATIN CAPITAL LETTER D WITH STROKE › LATIN CAPITAL LETTER D
                    case '\u018A':
                        sb.Append('\u0044');
                        break; //  ? › D    LATIN CAPITAL LETTER D WITH HOOK › LATIN CAPITAL LETTER D
                    case '\u018B':
                        sb.Append('\u0044');
                        break; //  ? › D    LATIN CAPITAL LETTER D WITH TOPBAR › LATIN CAPITAL LETTER D
                    case '\u1E0A':
                        sb.Append('\u0044');
                        break; //  ? › D    LATIN CAPITAL LETTER D WITH DOT ABOVE › LATIN CAPITAL LETTER D
                    case '\u1E0C':
                        sb.Append('\u0044');
                        break; //  ? › D    LATIN CAPITAL LETTER D WITH DOT BELOW › LATIN CAPITAL LETTER D
                    case '\u1E0E':
                        sb.Append('\u0044');
                        break; //  ? › D    LATIN CAPITAL LETTER D WITH LINE BELOW › LATIN CAPITAL LETTER D
                    case '\u1E10':
                        sb.Append('\u0044');
                        break; //  ? › D    LATIN CAPITAL LETTER D WITH CEDILLA › LATIN CAPITAL LETTER D
                    case '\u1E12':
                        sb.Append('\u0044');
                        break; //  ? › D    LATIN CAPITAL LETTER D WITH CIRCUMFLEX BELOW › LATIN CAPITAL LETTER D
                    case '\u00C8':
                        sb.Append('\u0045');
                        break; //  E › E    LATIN CAPITAL LETTER E WITH GRAVE › LATIN CAPITAL LETTER E
                    case '\u00C9':
                        sb.Append('\u0045');
                        break; //  É › E    LATIN CAPITAL LETTER E WITH ACUTE › LATIN CAPITAL LETTER E
                    case '\u00CA':
                        sb.Append('\u0045');
                        break; //  E › E    LATIN CAPITAL LETTER E WITH CIRCUMFLEX › LATIN CAPITAL LETTER E
                    case '\u00CB':
                        sb.Append('\u0045');
                        break; //  Ë › E    LATIN CAPITAL LETTER E WITH DIAERESIS › LATIN CAPITAL LETTER E
                    case '\u0112':
                        sb.Append('\u0045');
                        break; //  E › E    LATIN CAPITAL LETTER E WITH MACRON › LATIN CAPITAL LETTER E
                    case '\u0114':
                        sb.Append('\u0045');
                        break; //  E › E    LATIN CAPITAL LETTER E WITH BREVE › LATIN CAPITAL LETTER E
                    case '\u0116':
                        sb.Append('\u0045');
                        break; //  E › E    LATIN CAPITAL LETTER E WITH DOT ABOVE › LATIN CAPITAL LETTER E
                    case '\u0118':
                        sb.Append('\u0045');
                        break; //  Ę › E    LATIN CAPITAL LETTER E WITH OGONEK › LATIN CAPITAL LETTER E
                    case '\u011A':
                        sb.Append('\u0045');
                        break; //  Ě › E    LATIN CAPITAL LETTER E WITH CARON › LATIN CAPITAL LETTER E
                    case '\u0204':
                        sb.Append('\u0045');
                        break; //  ? › E    LATIN CAPITAL LETTER E WITH DOUBLE GRAVE › LATIN CAPITAL LETTER E
                    case '\u0206':
                        sb.Append('\u0045');
                        break; //  ? › E    LATIN CAPITAL LETTER E WITH INVERTED BREVE › LATIN CAPITAL LETTER E
                    case '\u0228':
                        sb.Append('\u0045');
                        break; //  ? › E    LATIN CAPITAL LETTER E WITH CEDILLA › LATIN CAPITAL LETTER E
                    case '\u1E14':
                        sb.Append('\u0045');
                        break; //  ? › E    LATIN CAPITAL LETTER E WITH MACRON AND GRAVE › LATIN CAPITAL LETTER E
                    case '\u1E16':
                        sb.Append('\u0045');
                        break; //  ? › E    LATIN CAPITAL LETTER E WITH MACRON AND ACUTE › LATIN CAPITAL LETTER E
                    case '\u1E18':
                        sb.Append('\u0045');
                        break; //  ? › E    LATIN CAPITAL LETTER E WITH CIRCUMFLEX BELOW › LATIN CAPITAL LETTER E
                    case '\u1E1A':
                        sb.Append('\u0045');
                        break; //  ? › E    LATIN CAPITAL LETTER E WITH TILDE BELOW › LATIN CAPITAL LETTER E
                    case '\u1E1C':
                        sb.Append('\u0045');
                        break; //  ? › E    LATIN CAPITAL LETTER E WITH CEDILLA AND BREVE › LATIN CAPITAL LETTER E
                    case '\u1EB8':
                        sb.Append('\u0045');
                        break; //  ? › E    LATIN CAPITAL LETTER E WITH DOT BELOW › LATIN CAPITAL LETTER E
                    case '\u1EBA':
                        sb.Append('\u0045');
                        break; //  ? › E    LATIN CAPITAL LETTER E WITH HOOK ABOVE › LATIN CAPITAL LETTER E
                    case '\u1EBC':
                        sb.Append('\u0045');
                        break; //  ? › E    LATIN CAPITAL LETTER E WITH TILDE › LATIN CAPITAL LETTER E
                    case '\u1EBE':
                        sb.Append('\u0045');
                        break; //  ? › E    LATIN CAPITAL LETTER E WITH CIRCUMFLEX AND ACUTE › LATIN CAPITAL LETTER E
                    case '\u1EC0':
                        sb.Append('\u0045');
                        break; //  ? › E    LATIN CAPITAL LETTER E WITH CIRCUMFLEX AND GRAVE › LATIN CAPITAL LETTER E
                    case '\u1EC2':
                        sb.Append('\u0045');
                        break; //  ? › E    LATIN CAPITAL LETTER E WITH CIRCUMFLEX AND HOOK ABOVE › LATIN CAPITAL LETTER E
                    case '\u1EC4':
                        sb.Append('\u0045');
                        break; //  ? › E    LATIN CAPITAL LETTER E WITH CIRCUMFLEX AND TILDE › LATIN CAPITAL LETTER E
                    case '\u1EC6':
                        sb.Append('\u0045');
                        break; //  ? › E    LATIN CAPITAL LETTER E WITH CIRCUMFLEX AND DOT BELOW › LATIN CAPITAL LETTER E
                    case '\u0191':
                        sb.Append('\u0046');
                        break; //  F › F    LATIN CAPITAL LETTER F WITH HOOK › LATIN CAPITAL LETTER F
                    case '\u1E1E':
                        sb.Append('\u0046');
                        break; //  ? › F    LATIN CAPITAL LETTER F WITH DOT ABOVE › LATIN CAPITAL LETTER F
                    case '\u011C':
                        sb.Append('\u0047');
                        break; //  G › G    LATIN CAPITAL LETTER G WITH CIRCUMFLEX › LATIN CAPITAL LETTER G
                    case '\u011E':
                        sb.Append('\u0047');
                        break; //  G › G    LATIN CAPITAL LETTER G WITH BREVE › LATIN CAPITAL LETTER G
                    case '\u0120':
                        sb.Append('\u0047');
                        break; //  G › G    LATIN CAPITAL LETTER G WITH DOT ABOVE › LATIN CAPITAL LETTER G
                    case '\u0122':
                        sb.Append('\u0047');
                        break; //  G › G    LATIN CAPITAL LETTER G WITH CEDILLA › LATIN CAPITAL LETTER G
                    case '\u0193':
                        sb.Append('\u0047');
                        break; //  ? › G    LATIN CAPITAL LETTER G WITH HOOK › LATIN CAPITAL LETTER G
                    case '\u01E4':
                        sb.Append('\u0047');
                        break; //  G › G    LATIN CAPITAL LETTER G WITH STROKE › LATIN CAPITAL LETTER G
                    case '\u01E6':
                        sb.Append('\u0047');
                        break; //  G › G    LATIN CAPITAL LETTER G WITH CARON › LATIN CAPITAL LETTER G
                    case '\u01F4':
                        sb.Append('\u0047');
                        break; //  ? › G    LATIN CAPITAL LETTER G WITH ACUTE › LATIN CAPITAL LETTER G
                    case '\u1E20':
                        sb.Append('\u0047');
                        break; //  ? › G    LATIN CAPITAL LETTER G WITH MACRON › LATIN CAPITAL LETTER G
                    case '\u0124':
                        sb.Append('\u0048');
                        break; //  H › H    LATIN CAPITAL LETTER H WITH CIRCUMFLEX › LATIN CAPITAL LETTER H
                    case '\u0126':
                        sb.Append('\u0048');
                        break; //  H › H    LATIN CAPITAL LETTER H WITH STROKE › LATIN CAPITAL LETTER H
                    case '\u021E':
                        sb.Append('\u0048');
                        break; //  ? › H    LATIN CAPITAL LETTER H WITH CARON › LATIN CAPITAL LETTER H
                    case '\u1E22':
                        sb.Append('\u0048');
                        break; //  ? › H    LATIN CAPITAL LETTER H WITH DOT ABOVE › LATIN CAPITAL LETTER H
                    case '\u1E24':
                        sb.Append('\u0048');
                        break; //  ? › H    LATIN CAPITAL LETTER H WITH DOT BELOW › LATIN CAPITAL LETTER H
                    case '\u1E26':
                        sb.Append('\u0048');
                        break; //  ? › H    LATIN CAPITAL LETTER H WITH DIAERESIS › LATIN CAPITAL LETTER H
                    case '\u1E28':
                        sb.Append('\u0048');
                        break; //  ? › H    LATIN CAPITAL LETTER H WITH CEDILLA › LATIN CAPITAL LETTER H
                    case '\u1E2A':
                        sb.Append('\u0048');
                        break; //  ? › H    LATIN CAPITAL LETTER H WITH BREVE BELOW › LATIN CAPITAL LETTER H
                    case '\u00CC':
                        sb.Append('\u0049');
                        break; //  I › I    LATIN CAPITAL LETTER I WITH GRAVE › LATIN CAPITAL LETTER I
                    case '\u00CD':
                        sb.Append('\u0049');
                        break; //  Í › I    LATIN CAPITAL LETTER I WITH ACUTE › LATIN CAPITAL LETTER I
                    case '\u00CE':
                        sb.Append('\u0049');
                        break; //  Î › I    LATIN CAPITAL LETTER I WITH CIRCUMFLEX › LATIN CAPITAL LETTER I
                    case '\u00CF':
                        sb.Append('\u0049');
                        break; //  I › I    LATIN CAPITAL LETTER I WITH DIAERESIS › LATIN CAPITAL LETTER I
                    case '\u0128':
                        sb.Append('\u0049');
                        break; //  I › I    LATIN CAPITAL LETTER I WITH TILDE › LATIN CAPITAL LETTER I
                    case '\u012A':
                        sb.Append('\u0049');
                        break; //  I › I    LATIN CAPITAL LETTER I WITH MACRON › LATIN CAPITAL LETTER I
                    case '\u012C':
                        sb.Append('\u0049');
                        break; //  I › I    LATIN CAPITAL LETTER I WITH BREVE › LATIN CAPITAL LETTER I
                    case '\u012E':
                        sb.Append('\u0049');
                        break; //  I › I    LATIN CAPITAL LETTER I WITH OGONEK › LATIN CAPITAL LETTER I
                    case '\u0130':
                        sb.Append('\u0049');
                        break; //  I › I    LATIN CAPITAL LETTER I WITH DOT ABOVE › LATIN CAPITAL LETTER I
                    case '\u0197':
                        sb.Append('\u0049');
                        break; //  I › I    LATIN CAPITAL LETTER I WITH STROKE › LATIN CAPITAL LETTER I
                    case '\u01CF':
                        sb.Append('\u0049');
                        break; //  I › I    LATIN CAPITAL LETTER I WITH CARON › LATIN CAPITAL LETTER I
                    case '\u0208':
                        sb.Append('\u0049');
                        break; //  ? › I    LATIN CAPITAL LETTER I WITH DOUBLE GRAVE › LATIN CAPITAL LETTER I
                    case '\u020A':
                        sb.Append('\u0049');
                        break; //  ? › I    LATIN CAPITAL LETTER I WITH INVERTED BREVE › LATIN CAPITAL LETTER I
                    case '\u1E2C':
                        sb.Append('\u0049');
                        break; //  ? › I    LATIN CAPITAL LETTER I WITH TILDE BELOW › LATIN CAPITAL LETTER I
                    case '\u1E2E':
                        sb.Append('\u0049');
                        break; //  ? › I    LATIN CAPITAL LETTER I WITH DIAERESIS AND ACUTE › LATIN CAPITAL LETTER I
                    case '\u1EC8':
                        sb.Append('\u0049');
                        break; //  ? › I    LATIN CAPITAL LETTER I WITH HOOK ABOVE › LATIN CAPITAL LETTER I
                    case '\u1ECA':
                        sb.Append('\u0049');
                        break; //  ? › I    LATIN CAPITAL LETTER I WITH DOT BELOW › LATIN CAPITAL LETTER I
                    case '\u0134':
                        sb.Append('\u004A');
                        break; //  J › J    LATIN CAPITAL LETTER J WITH CIRCUMFLEX › LATIN CAPITAL LETTER J
                    case '\u0136':
                        sb.Append('\u004B');
                        break; //  K › K    LATIN CAPITAL LETTER K WITH CEDILLA › LATIN CAPITAL LETTER K
                    case '\u0198':
                        sb.Append('\u004B');
                        break; //  ? › K    LATIN CAPITAL LETTER K WITH HOOK › LATIN CAPITAL LETTER K
                    case '\u01E8':
                        sb.Append('\u004B');
                        break; //  K › K    LATIN CAPITAL LETTER K WITH CARON › LATIN CAPITAL LETTER K
                    case '\u1E30':
                        sb.Append('\u004B');
                        break; //  ? › K    LATIN CAPITAL LETTER K WITH ACUTE › LATIN CAPITAL LETTER K
                    case '\u1E32':
                        sb.Append('\u004B');
                        break; //  ? › K    LATIN CAPITAL LETTER K WITH DOT BELOW › LATIN CAPITAL LETTER K
                    case '\u1E34':
                        sb.Append('\u004B');
                        break; //  ? › K    LATIN CAPITAL LETTER K WITH LINE BELOW › LATIN CAPITAL LETTER K
                    case '\u0139':
                        sb.Append('\u004C');
                        break; //  Ĺ › L    LATIN CAPITAL LETTER L WITH ACUTE › LATIN CAPITAL LETTER L
                    case '\u013B':
                        sb.Append('\u004C');
                        break; //  L › L    LATIN CAPITAL LETTER L WITH CEDILLA › LATIN CAPITAL LETTER L
                    case '\u013D':
                        sb.Append('\u004C');
                        break; //  Ľ › L    LATIN CAPITAL LETTER L WITH CARON › LATIN CAPITAL LETTER L
                    case '\u0141':
                        sb.Append('\u004C');
                        break; //  Ł › L    LATIN CAPITAL LETTER L WITH STROKE › LATIN CAPITAL LETTER L
                    case '\u1E36':
                        sb.Append('\u004C');
                        break; //  ? › L    LATIN CAPITAL LETTER L WITH DOT BELOW › LATIN CAPITAL LETTER L
                    case '\u1E38':
                        sb.Append('\u004C');
                        break; //  ? › L    LATIN CAPITAL LETTER L WITH DOT BELOW AND MACRON › LATIN CAPITAL LETTER L
                    case '\u1E3A':
                        sb.Append('\u004C');
                        break; //  ? › L    LATIN CAPITAL LETTER L WITH LINE BELOW › LATIN CAPITAL LETTER L
                    case '\u1E3C':
                        sb.Append('\u004C');
                        break; //  ? › L    LATIN CAPITAL LETTER L WITH CIRCUMFLEX BELOW › LATIN CAPITAL LETTER L
                    case '\u1E3E':
                        sb.Append('\u004D');
                        break; //  ? › M    LATIN CAPITAL LETTER M WITH ACUTE › LATIN CAPITAL LETTER M
                    case '\u1E40':
                        sb.Append('\u004D');
                        break; //  ? › M    LATIN CAPITAL LETTER M WITH DOT ABOVE › LATIN CAPITAL LETTER M
                    case '\u1E42':
                        sb.Append('\u004D');
                        break; //  ? › M    LATIN CAPITAL LETTER M WITH DOT BELOW › LATIN CAPITAL LETTER M
                    case '\u00D1':
                        sb.Append('\u004E');
                        break; //  N › N    LATIN CAPITAL LETTER N WITH TILDE › LATIN CAPITAL LETTER N
                    case '\u0143':
                        sb.Append('\u004E');
                        break; //  Ń › N    LATIN CAPITAL LETTER N WITH ACUTE › LATIN CAPITAL LETTER N
                    case '\u0145':
                        sb.Append('\u004E');
                        break; //  N › N    LATIN CAPITAL LETTER N WITH CEDILLA › LATIN CAPITAL LETTER N
                    case '\u0147':
                        sb.Append('\u004E');
                        break; //  Ň › N    LATIN CAPITAL LETTER N WITH CARON › LATIN CAPITAL LETTER N
                    case '\u019D':
                        sb.Append('\u004E');
                        break; //  ? › N    LATIN CAPITAL LETTER N WITH LEFT HOOK › LATIN CAPITAL LETTER N
                    case '\u01F8':
                        sb.Append('\u004E');
                        break; //  ? › N    LATIN CAPITAL LETTER N WITH GRAVE › LATIN CAPITAL LETTER N
                    case '\u0220':
                        sb.Append('\u004E');
                        break; //  ? › N    LATIN CAPITAL LETTER N WITH LONG RIGHT LEG › LATIN CAPITAL LETTER N
                    case '\u1E44':
                        sb.Append('\u004E');
                        break; //  ? › N    LATIN CAPITAL LETTER N WITH DOT ABOVE › LATIN CAPITAL LETTER N
                    case '\u1E46':
                        sb.Append('\u004E');
                        break; //  ? › N    LATIN CAPITAL LETTER N WITH DOT BELOW › LATIN CAPITAL LETTER N
                    case '\u1E48':
                        sb.Append('\u004E');
                        break; //  ? › N    LATIN CAPITAL LETTER N WITH LINE BELOW › LATIN CAPITAL LETTER N
                    case '\u1E4A':
                        sb.Append('\u004E');
                        break; //  ? › N    LATIN CAPITAL LETTER N WITH CIRCUMFLEX BELOW › LATIN CAPITAL LETTER N
                    case '\u00D2':
                        sb.Append('\u004F');
                        break; //  O › O    LATIN CAPITAL LETTER O WITH GRAVE › LATIN CAPITAL LETTER O
                    case '\u00D3':
                        sb.Append('\u004F');
                        break; //  Ó › O    LATIN CAPITAL LETTER O WITH ACUTE › LATIN CAPITAL LETTER O
                    case '\u00D4':
                        sb.Append('\u004F');
                        break; //  Ô › O    LATIN CAPITAL LETTER O WITH CIRCUMFLEX › LATIN CAPITAL LETTER O
                    case '\u00D5':
                        sb.Append('\u004F');
                        break; //  O › O    LATIN CAPITAL LETTER O WITH TILDE › LATIN CAPITAL LETTER O
                    case '\u00D6':
                        sb.Append('\u004F');
                        break; //  Ö › O    LATIN CAPITAL LETTER O WITH DIAERESIS › LATIN CAPITAL LETTER O
                    case '\u00D8':
                        sb.Append('\u004F');
                        break; //  O › O    LATIN CAPITAL LETTER O WITH STROKE › LATIN CAPITAL LETTER O
                    case '\u014C':
                        sb.Append('\u004F');
                        break; //  O › O    LATIN CAPITAL LETTER O WITH MACRON › LATIN CAPITAL LETTER O
                    case '\u014E':
                        sb.Append('\u004F');
                        break; //  O › O    LATIN CAPITAL LETTER O WITH BREVE › LATIN CAPITAL LETTER O
                    case '\u0150':
                        sb.Append('\u004F');
                        break; //  Ő › O    LATIN CAPITAL LETTER O WITH DOUBLE ACUTE › LATIN CAPITAL LETTER O
                    case '\u019F':
                        sb.Append('\u004F');
                        break; //  O › O    LATIN CAPITAL LETTER O WITH MIDDLE TILDE › LATIN CAPITAL LETTER O
                    case '\u01A0':
                        sb.Append('\u004F');
                        break; //  O › O    LATIN CAPITAL LETTER O WITH HORN › LATIN CAPITAL LETTER O
                    case '\u01D1':
                        sb.Append('\u004F');
                        break; //  O › O    LATIN CAPITAL LETTER O WITH CARON › LATIN CAPITAL LETTER O
                    case '\u01EA':
                        sb.Append('\u004F');
                        break; //  O › O    LATIN CAPITAL LETTER O WITH OGONEK › LATIN CAPITAL LETTER O
                    case '\u01EC':
                        sb.Append('\u004F');
                        break; //  O › O    LATIN CAPITAL LETTER O WITH OGONEK AND MACRON › LATIN CAPITAL LETTER O
                    case '\u01FE':
                        sb.Append('\u004F');
                        break; //  ? › O    LATIN CAPITAL LETTER O WITH STROKE AND ACUTE › LATIN CAPITAL LETTER O
                    case '\u020C':
                        sb.Append('\u004F');
                        break; //  ? › O    LATIN CAPITAL LETTER O WITH DOUBLE GRAVE › LATIN CAPITAL LETTER O
                    case '\u020E':
                        sb.Append('\u004F');
                        break; //  ? › O    LATIN CAPITAL LETTER O WITH INVERTED BREVE › LATIN CAPITAL LETTER O
                    case '\u022A':
                        sb.Append('\u004F');
                        break; //  ? › O    LATIN CAPITAL LETTER O WITH DIAERESIS AND MACRON › LATIN CAPITAL LETTER O
                    case '\u022C':
                        sb.Append('\u004F');
                        break; //  ? › O    LATIN CAPITAL LETTER O WITH TILDE AND MACRON › LATIN CAPITAL LETTER O
                    case '\u022E':
                        sb.Append('\u004F');
                        break; //  ? › O    LATIN CAPITAL LETTER O WITH DOT ABOVE › LATIN CAPITAL LETTER O
                    case '\u0230':
                        sb.Append('\u004F');
                        break; //  ? › O    LATIN CAPITAL LETTER O WITH DOT ABOVE AND MACRON › LATIN CAPITAL LETTER O
                    case '\u1E4C':
                        sb.Append('\u004F');
                        break; //  ? › O    LATIN CAPITAL LETTER O WITH TILDE AND ACUTE › LATIN CAPITAL LETTER O
                    case '\u1E4E':
                        sb.Append('\u004F');
                        break; //  ? › O    LATIN CAPITAL LETTER O WITH TILDE AND DIAERESIS › LATIN CAPITAL LETTER O
                    case '\u1E50':
                        sb.Append('\u004F');
                        break; //  ? › O    LATIN CAPITAL LETTER O WITH MACRON AND GRAVE › LATIN CAPITAL LETTER O
                    case '\u1E52':
                        sb.Append('\u004F');
                        break; //  ? › O    LATIN CAPITAL LETTER O WITH MACRON AND ACUTE › LATIN CAPITAL LETTER O
                    case '\u1ECC':
                        sb.Append('\u004F');
                        break; //  ? › O    LATIN CAPITAL LETTER O WITH DOT BELOW › LATIN CAPITAL LETTER O
                    case '\u1ECE':
                        sb.Append('\u004F');
                        break; //  ? › O    LATIN CAPITAL LETTER O WITH HOOK ABOVE › LATIN CAPITAL LETTER O
                    case '\u1ED0':
                        sb.Append('\u004F');
                        break; //  ? › O    LATIN CAPITAL LETTER O WITH CIRCUMFLEX AND ACUTE › LATIN CAPITAL LETTER O
                    case '\u1ED2':
                        sb.Append('\u004F');
                        break; //  ? › O    LATIN CAPITAL LETTER O WITH CIRCUMFLEX AND GRAVE › LATIN CAPITAL LETTER O
                    case '\u1ED4':
                        sb.Append('\u004F');
                        break; //  ? › O    LATIN CAPITAL LETTER O WITH CIRCUMFLEX AND HOOK ABOVE › LATIN CAPITAL LETTER O
                    case '\u1ED6':
                        sb.Append('\u004F');
                        break; //  ? › O    LATIN CAPITAL LETTER O WITH CIRCUMFLEX AND TILDE › LATIN CAPITAL LETTER O
                    case '\u1ED8':
                        sb.Append('\u004F');
                        break; //  ? › O    LATIN CAPITAL LETTER O WITH CIRCUMFLEX AND DOT BELOW › LATIN CAPITAL LETTER O
                    case '\u1EDA':
                        sb.Append('\u004F');
                        break; //  ? › O    LATIN CAPITAL LETTER O WITH HORN AND ACUTE › LATIN CAPITAL LETTER O
                    case '\u1EDC':
                        sb.Append('\u004F');
                        break; //  ? › O    LATIN CAPITAL LETTER O WITH HORN AND GRAVE › LATIN CAPITAL LETTER O
                    case '\u1EDE':
                        sb.Append('\u004F');
                        break; //  ? › O    LATIN CAPITAL LETTER O WITH HORN AND HOOK ABOVE › LATIN CAPITAL LETTER O
                    case '\u1EE0':
                        sb.Append('\u004F');
                        break; //  ? › O    LATIN CAPITAL LETTER O WITH HORN AND TILDE › LATIN CAPITAL LETTER O
                    case '\u1EE2':
                        sb.Append('\u004F');
                        break; //  ? › O    LATIN CAPITAL LETTER O WITH HORN AND DOT BELOW › LATIN CAPITAL LETTER O
                    case '\u01A4':
                        sb.Append('\u0050');
                        break; //  ? › P    LATIN CAPITAL LETTER P WITH HOOK › LATIN CAPITAL LETTER P
                    case '\u1E54':
                        sb.Append('\u0050');
                        break; //  ? › P    LATIN CAPITAL LETTER P WITH ACUTE › LATIN CAPITAL LETTER P
                    case '\u1E56':
                        sb.Append('\u0050');
                        break; //  ? › P    LATIN CAPITAL LETTER P WITH DOT ABOVE › LATIN CAPITAL LETTER P
                    case '\u0154':
                        sb.Append('\u0052');
                        break; //  Ŕ › R    LATIN CAPITAL LETTER R WITH ACUTE › LATIN CAPITAL LETTER R
                    case '\u0156':
                        sb.Append('\u0052');
                        break; //  R › R    LATIN CAPITAL LETTER R WITH CEDILLA › LATIN CAPITAL LETTER R
                    case '\u0158':
                        sb.Append('\u0052');
                        break; //  Ř › R    LATIN CAPITAL LETTER R WITH CARON › LATIN CAPITAL LETTER R
                    case '\u0210':
                        sb.Append('\u0052');
                        break; //  ? › R    LATIN CAPITAL LETTER R WITH DOUBLE GRAVE › LATIN CAPITAL LETTER R
                    case '\u0212':
                        sb.Append('\u0052');
                        break; //  ? › R    LATIN CAPITAL LETTER R WITH INVERTED BREVE › LATIN CAPITAL LETTER R
                    case '\u1E58':
                        sb.Append('\u0052');
                        break; //  ? › R    LATIN CAPITAL LETTER R WITH DOT ABOVE › LATIN CAPITAL LETTER R
                    case '\u1E5A':
                        sb.Append('\u0052');
                        break; //  ? › R    LATIN CAPITAL LETTER R WITH DOT BELOW › LATIN CAPITAL LETTER R
                    case '\u1E5C':
                        sb.Append('\u0052');
                        break; //  ? › R    LATIN CAPITAL LETTER R WITH DOT BELOW AND MACRON › LATIN CAPITAL LETTER R
                    case '\u1E5E':
                        sb.Append('\u0052');
                        break; //  ? › R    LATIN CAPITAL LETTER R WITH LINE BELOW › LATIN CAPITAL LETTER R
                    case '\u015A':
                        sb.Append('\u0053');
                        break; //  Ś › S    LATIN CAPITAL LETTER S WITH ACUTE › LATIN CAPITAL LETTER S
                    case '\u015C':
                        sb.Append('\u0053');
                        break; //  S › S    LATIN CAPITAL LETTER S WITH CIRCUMFLEX › LATIN CAPITAL LETTER S
                    case '\u015E':
                        sb.Append('\u0053');
                        break; //  Ş › S    LATIN CAPITAL LETTER S WITH CEDILLA › LATIN CAPITAL LETTER S
                    case '\u0160':
                        sb.Append('\u0053');
                        break; //  Š › S    LATIN CAPITAL LETTER S WITH CARON › LATIN CAPITAL LETTER S
                    case '\u0218':
                        sb.Append('\u0053');
                        break; //  ? › S    LATIN CAPITAL LETTER S WITH COMMA BELOW › LATIN CAPITAL LETTER S
                    case '\u1E60':
                        sb.Append('\u0053');
                        break; //  ? › S    LATIN CAPITAL LETTER S WITH DOT ABOVE › LATIN CAPITAL LETTER S
                    case '\u1E62':
                        sb.Append('\u0053');
                        break; //  ? › S    LATIN CAPITAL LETTER S WITH DOT BELOW › LATIN CAPITAL LETTER S
                    case '\u1E64':
                        sb.Append('\u0053');
                        break; //  ? › S    LATIN CAPITAL LETTER S WITH ACUTE AND DOT ABOVE › LATIN CAPITAL LETTER S
                    case '\u1E66':
                        sb.Append('\u0053');
                        break; //  ? › S    LATIN CAPITAL LETTER S WITH CARON AND DOT ABOVE › LATIN CAPITAL LETTER S
                    case '\u1E68':
                        sb.Append('\u0053');
                        break; //  ? › S    LATIN CAPITAL LETTER S WITH DOT BELOW AND DOT ABOVE › LATIN CAPITAL LETTER S
                    case '\u0162':
                        sb.Append('\u0054');
                        break; //  Ţ › T    LATIN CAPITAL LETTER T WITH CEDILLA › LATIN CAPITAL LETTER T
                    case '\u0164':
                        sb.Append('\u0054');
                        break; //  Ť › T    LATIN CAPITAL LETTER T WITH CARON › LATIN CAPITAL LETTER T
                    case '\u0166':
                        sb.Append('\u0054');
                        break; //  T › T    LATIN CAPITAL LETTER T WITH STROKE › LATIN CAPITAL LETTER T
                    case '\u01AC':
                        sb.Append('\u0054');
                        break; //  ? › T    LATIN CAPITAL LETTER T WITH HOOK › LATIN CAPITAL LETTER T
                    case '\u01AE':
                        sb.Append('\u0054');
                        break; //  T › T    LATIN CAPITAL LETTER T WITH RETROFLEX HOOK › LATIN CAPITAL LETTER T
                    case '\u021A':
                        sb.Append('\u0054');
                        break; //  ? › T    LATIN CAPITAL LETTER T WITH COMMA BELOW › LATIN CAPITAL LETTER T
                    case '\u1E6A':
                        sb.Append('\u0054');
                        break; //  ? › T    LATIN CAPITAL LETTER T WITH DOT ABOVE › LATIN CAPITAL LETTER T
                    case '\u1E6C':
                        sb.Append('\u0054');
                        break; //  ? › T    LATIN CAPITAL LETTER T WITH DOT BELOW › LATIN CAPITAL LETTER T
                    case '\u1E6E':
                        sb.Append('\u0054');
                        break; //  ? › T    LATIN CAPITAL LETTER T WITH LINE BELOW › LATIN CAPITAL LETTER T
                    case '\u1E70':
                        sb.Append('\u0054');
                        break; //  ? › T    LATIN CAPITAL LETTER T WITH CIRCUMFLEX BELOW › LATIN CAPITAL LETTER T
                    case '\u00D9':
                        sb.Append('\u0055');
                        break; //  U › U    LATIN CAPITAL LETTER U WITH GRAVE › LATIN CAPITAL LETTER U
                    case '\u00DA':
                        sb.Append('\u0055');
                        break; //  Ú › U    LATIN CAPITAL LETTER U WITH ACUTE › LATIN CAPITAL LETTER U
                    case '\u00DB':
                        sb.Append('\u0055');
                        break; //  U › U    LATIN CAPITAL LETTER U WITH CIRCUMFLEX › LATIN CAPITAL LETTER U
                    case '\u00DC':
                        sb.Append('\u0055');
                        break; //  Ü › U    LATIN CAPITAL LETTER U WITH DIAERESIS › LATIN CAPITAL LETTER U
                    case '\u0168':
                        sb.Append('\u0055');
                        break; //  U › U    LATIN CAPITAL LETTER U WITH TILDE › LATIN CAPITAL LETTER U
                    case '\u016A':
                        sb.Append('\u0055');
                        break; //  U › U    LATIN CAPITAL LETTER U WITH MACRON › LATIN CAPITAL LETTER U
                    case '\u016C':
                        sb.Append('\u0055');
                        break; //  U › U    LATIN CAPITAL LETTER U WITH BREVE › LATIN CAPITAL LETTER U
                    case '\u016E':
                        sb.Append('\u0055');
                        break; //  Ů › U    LATIN CAPITAL LETTER U WITH RING ABOVE › LATIN CAPITAL LETTER U
                    case '\u0170':
                        sb.Append('\u0055');
                        break; //  Ű › U    LATIN CAPITAL LETTER U WITH DOUBLE ACUTE › LATIN CAPITAL LETTER U
                    case '\u0172':
                        sb.Append('\u0055');
                        break; //  U › U    LATIN CAPITAL LETTER U WITH OGONEK › LATIN CAPITAL LETTER U
                    case '\u01AF':
                        sb.Append('\u0055');
                        break; //  U › U    LATIN CAPITAL LETTER U WITH HORN › LATIN CAPITAL LETTER U
                    case '\u01D3':
                        sb.Append('\u0055');
                        break; //  U › U    LATIN CAPITAL LETTER U WITH CARON › LATIN CAPITAL LETTER U
                    case '\u01D5':
                        sb.Append('\u0055');
                        break; //  U › U    LATIN CAPITAL LETTER U WITH DIAERESIS AND MACRON › LATIN CAPITAL LETTER U
                    case '\u01D7':
                        sb.Append('\u0055');
                        break; //  U › U    LATIN CAPITAL LETTER U WITH DIAERESIS AND ACUTE › LATIN CAPITAL LETTER U
                    case '\u01D9':
                        sb.Append('\u0055');
                        break; //  U › U    LATIN CAPITAL LETTER U WITH DIAERESIS AND CARON › LATIN CAPITAL LETTER U
                    case '\u01DB':
                        sb.Append('\u0055');
                        break; //  U › U    LATIN CAPITAL LETTER U WITH DIAERESIS AND GRAVE › LATIN CAPITAL LETTER U
                    case '\u0214':
                        sb.Append('\u0055');
                        break; //  ? › U    LATIN CAPITAL LETTER U WITH DOUBLE GRAVE › LATIN CAPITAL LETTER U
                    case '\u0216':
                        sb.Append('\u0055');
                        break; //  ? › U    LATIN CAPITAL LETTER U WITH INVERTED BREVE › LATIN CAPITAL LETTER U
                    case '\u1E72':
                        sb.Append('\u0055');
                        break; //  ? › U    LATIN CAPITAL LETTER U WITH DIAERESIS BELOW › LATIN CAPITAL LETTER U
                    case '\u1E74':
                        sb.Append('\u0055');
                        break; //  ? › U    LATIN CAPITAL LETTER U WITH TILDE BELOW › LATIN CAPITAL LETTER U
                    case '\u1E76':
                        sb.Append('\u0055');
                        break; //  ? › U    LATIN CAPITAL LETTER U WITH CIRCUMFLEX BELOW › LATIN CAPITAL LETTER U
                    case '\u1E78':
                        sb.Append('\u0055');
                        break; //  ? › U    LATIN CAPITAL LETTER U WITH TILDE AND ACUTE › LATIN CAPITAL LETTER U
                    case '\u1E7A':
                        sb.Append('\u0055');
                        break; //  ? › U    LATIN CAPITAL LETTER U WITH MACRON AND DIAERESIS › LATIN CAPITAL LETTER U
                    case '\u1EE4':
                        sb.Append('\u0055');
                        break; //  ? › U    LATIN CAPITAL LETTER U WITH DOT BELOW › LATIN CAPITAL LETTER U
                    case '\u1EE6':
                        sb.Append('\u0055');
                        break; //  ? › U    LATIN CAPITAL LETTER U WITH HOOK ABOVE › LATIN CAPITAL LETTER U
                    case '\u1EE8':
                        sb.Append('\u0055');
                        break; //  ? › U    LATIN CAPITAL LETTER U WITH HORN AND ACUTE › LATIN CAPITAL LETTER U
                    case '\u1EEA':
                        sb.Append('\u0055');
                        break; //  ? › U    LATIN CAPITAL LETTER U WITH HORN AND GRAVE › LATIN CAPITAL LETTER U
                    case '\u1EEC':
                        sb.Append('\u0055');
                        break; //  ? › U    LATIN CAPITAL LETTER U WITH HORN AND HOOK ABOVE › LATIN CAPITAL LETTER U
                    case '\u1EEE':
                        sb.Append('\u0055');
                        break; //  ? › U    LATIN CAPITAL LETTER U WITH HORN AND TILDE › LATIN CAPITAL LETTER U
                    case '\u1EF0':
                        sb.Append('\u0055');
                        break; //  ? › U    LATIN CAPITAL LETTER U WITH HORN AND DOT BELOW › LATIN CAPITAL LETTER U
                    case '\u01B2':
                        sb.Append('\u0056');
                        break; //  ? › V    LATIN CAPITAL LETTER V WITH HOOK › LATIN CAPITAL LETTER V
                    case '\u1E7C':
                        sb.Append('\u0056');
                        break; //  ? › V    LATIN CAPITAL LETTER V WITH TILDE › LATIN CAPITAL LETTER V
                    case '\u1E7E':
                        sb.Append('\u0056');
                        break; //  ? › V    LATIN CAPITAL LETTER V WITH DOT BELOW › LATIN CAPITAL LETTER V
                    case '\u0174':
                        sb.Append('\u0057');
                        break; //  W › W    LATIN CAPITAL LETTER W WITH CIRCUMFLEX › LATIN CAPITAL LETTER W
                    case '\u1E80':
                        sb.Append('\u0057');
                        break; //  ? › W    LATIN CAPITAL LETTER W WITH GRAVE › LATIN CAPITAL LETTER W
                    case '\u1E82':
                        sb.Append('\u0057');
                        break; //  ? › W    LATIN CAPITAL LETTER W WITH ACUTE › LATIN CAPITAL LETTER W
                    case '\u1E84':
                        sb.Append('\u0057');
                        break; //  ? › W    LATIN CAPITAL LETTER W WITH DIAERESIS › LATIN CAPITAL LETTER W
                    case '\u1E86':
                        sb.Append('\u0057');
                        break; //  ? › W    LATIN CAPITAL LETTER W WITH DOT ABOVE › LATIN CAPITAL LETTER W
                    case '\u1E88':
                        sb.Append('\u0057');
                        break; //  ? › W    LATIN CAPITAL LETTER W WITH DOT BELOW › LATIN CAPITAL LETTER W
                    case '\u1E8A':
                        sb.Append('\u0058');
                        break; //  ? › X    LATIN CAPITAL LETTER X WITH DOT ABOVE › LATIN CAPITAL LETTER X
                    case '\u1E8C':
                        sb.Append('\u0058');
                        break; //  ? › X    LATIN CAPITAL LETTER X WITH DIAERESIS › LATIN CAPITAL LETTER X
                    case '\u00DD':
                        sb.Append('\u0059');
                        break; //  Ý › Y    LATIN CAPITAL LETTER Y WITH ACUTE › LATIN CAPITAL LETTER Y
                    case '\u0176':
                        sb.Append('\u0059');
                        break; //  Y › Y    LATIN CAPITAL LETTER Y WITH CIRCUMFLEX › LATIN CAPITAL LETTER Y
                    case '\u0178':
                        sb.Append('\u0059');
                        break; //  Y › Y    LATIN CAPITAL LETTER Y WITH DIAERESIS › LATIN CAPITAL LETTER Y
                    case '\u01B3':
                        sb.Append('\u0059');
                        break; //  ? › Y    LATIN CAPITAL LETTER Y WITH HOOK › LATIN CAPITAL LETTER Y
                    case '\u0232':
                        sb.Append('\u0059');
                        break; //  ? › Y    LATIN CAPITAL LETTER Y WITH MACRON › LATIN CAPITAL LETTER Y
                    case '\u1E8E':
                        sb.Append('\u0059');
                        break; //  ? › Y    LATIN CAPITAL LETTER Y WITH DOT ABOVE › LATIN CAPITAL LETTER Y
                    case '\u1EF2':
                        sb.Append('\u0059');
                        break; //  ? › Y    LATIN CAPITAL LETTER Y WITH GRAVE › LATIN CAPITAL LETTER Y
                    case '\u1EF4':
                        sb.Append('\u0059');
                        break; //  ? › Y    LATIN CAPITAL LETTER Y WITH DOT BELOW › LATIN CAPITAL LETTER Y
                    case '\u1EF6':
                        sb.Append('\u0059');
                        break; //  ? › Y    LATIN CAPITAL LETTER Y WITH HOOK ABOVE › LATIN CAPITAL LETTER Y
                    case '\u1EF8':
                        sb.Append('\u0059');
                        break; //  ? › Y    LATIN CAPITAL LETTER Y WITH TILDE › LATIN CAPITAL LETTER Y
                    case '\u0179':
                        sb.Append('\u005A');
                        break; //  Ź › Z    LATIN CAPITAL LETTER Z WITH ACUTE › LATIN CAPITAL LETTER Z
                    case '\u017B':
                        sb.Append('\u005A');
                        break; //  Ż › Z    LATIN CAPITAL LETTER Z WITH DOT ABOVE › LATIN CAPITAL LETTER Z
                    case '\u017D':
                        sb.Append('\u005A');
                        break; //  Ž › Z    LATIN CAPITAL LETTER Z WITH CARON › LATIN CAPITAL LETTER Z
                    case '\u01B5':
                        sb.Append('\u005A');
                        break; //  ? › Z    LATIN CAPITAL LETTER Z WITH STROKE › LATIN CAPITAL LETTER Z
                    case '\u0224':
                        sb.Append('\u005A');
                        break; //  ? › Z    LATIN CAPITAL LETTER Z WITH HOOK › LATIN CAPITAL LETTER Z
                    case '\u1E90':
                        sb.Append('\u005A');
                        break; //  ? › Z    LATIN CAPITAL LETTER Z WITH CIRCUMFLEX › LATIN CAPITAL LETTER Z
                    case '\u1E92':
                        sb.Append('\u005A');
                        break; //  ? › Z    LATIN CAPITAL LETTER Z WITH DOT BELOW › LATIN CAPITAL LETTER Z
                    case '\u1E94':
                        sb.Append('\u005A');
                        break; //  ? › Z    LATIN CAPITAL LETTER Z WITH LINE BELOW › LATIN CAPITAL LETTER Z
                    case '\u00E0':
                        sb.Append('\u0061');
                        break; //  a › a    LATIN SMALL LETTER A WITH GRAVE › LATIN SMALL LETTER A
                    case '\u00E1':
                        sb.Append('\u0061');
                        break; //  á › a    LATIN SMALL LETTER A WITH ACUTE › LATIN SMALL LETTER A
                    case '\u00E2':
                        sb.Append('\u0061');
                        break; //  â › a    LATIN SMALL LETTER A WITH CIRCUMFLEX › LATIN SMALL LETTER A
                    case '\u00E3':
                        sb.Append('\u0061');
                        break; //  a › a    LATIN SMALL LETTER A WITH TILDE › LATIN SMALL LETTER A
                    case '\u00E4':
                        sb.Append('\u0061');
                        break; //  ä › a    LATIN SMALL LETTER A WITH DIAERESIS › LATIN SMALL LETTER A
                    case '\u00E5':
                        sb.Append('\u0061');
                        break; //  a › a    LATIN SMALL LETTER A WITH RING ABOVE › LATIN SMALL LETTER A
                    case '\u0101':
                        sb.Append('\u0061');
                        break; //  a › a    LATIN SMALL LETTER A WITH MACRON › LATIN SMALL LETTER A
                    case '\u0103':
                        sb.Append('\u0061');
                        break; //  ă › a    LATIN SMALL LETTER A WITH BREVE › LATIN SMALL LETTER A
                    case '\u0105':
                        sb.Append('\u0061');
                        break; //  ą › a    LATIN SMALL LETTER A WITH OGONEK › LATIN SMALL LETTER A
                    case '\u01CE':
                        sb.Append('\u0061');
                        break; //  a › a    LATIN SMALL LETTER A WITH CARON › LATIN SMALL LETTER A
                    case '\u01DF':
                        sb.Append('\u0061');
                        break; //  a › a    LATIN SMALL LETTER A WITH DIAERESIS AND MACRON › LATIN SMALL LETTER A
                    case '\u01E1':
                        sb.Append('\u0061');
                        break; //  ? › a    LATIN SMALL LETTER A WITH DOT ABOVE AND MACRON › LATIN SMALL LETTER A
                    case '\u01FB':
                        sb.Append('\u0061');
                        break; //  ? › a    LATIN SMALL LETTER A WITH RING ABOVE AND ACUTE › LATIN SMALL LETTER A
                    case '\u0201':
                        sb.Append('\u0061');
                        break; //  ? › a    LATIN SMALL LETTER A WITH DOUBLE GRAVE › LATIN SMALL LETTER A
                    case '\u0203':
                        sb.Append('\u0061');
                        break; //  ? › a    LATIN SMALL LETTER A WITH INVERTED BREVE › LATIN SMALL LETTER A
                    case '\u0227':
                        sb.Append('\u0061');
                        break; //  ? › a    LATIN SMALL LETTER A WITH DOT ABOVE › LATIN SMALL LETTER A
                    case '\u1E01':
                        sb.Append('\u0061');
                        break; //  ? › a    LATIN SMALL LETTER A WITH RING BELOW › LATIN SMALL LETTER A
                    case '\u1E9A':
                        sb.Append('\u0061');
                        break; //  ? › a    LATIN SMALL LETTER A WITH RIGHT HALF RING › LATIN SMALL LETTER A
                    case '\u1EA1':
                        sb.Append('\u0061');
                        break; //  ? › a    LATIN SMALL LETTER A WITH DOT BELOW › LATIN SMALL LETTER A
                    case '\u1EA3':
                        sb.Append('\u0061');
                        break; //  ? › a    LATIN SMALL LETTER A WITH HOOK ABOVE › LATIN SMALL LETTER A
                    case '\u1EA5':
                        sb.Append('\u0061');
                        break; //  ? › a    LATIN SMALL LETTER A WITH CIRCUMFLEX AND ACUTE › LATIN SMALL LETTER A
                    case '\u1EA7':
                        sb.Append('\u0061');
                        break; //  ? › a    LATIN SMALL LETTER A WITH CIRCUMFLEX AND GRAVE › LATIN SMALL LETTER A
                    case '\u1EA9':
                        sb.Append('\u0061');
                        break; //  ? › a    LATIN SMALL LETTER A WITH CIRCUMFLEX AND HOOK ABOVE › LATIN SMALL LETTER A
                    case '\u1EAB':
                        sb.Append('\u0061');
                        break; //  ? › a    LATIN SMALL LETTER A WITH CIRCUMFLEX AND TILDE › LATIN SMALL LETTER A
                    case '\u1EAD':
                        sb.Append('\u0061');
                        break; //  ? › a    LATIN SMALL LETTER A WITH CIRCUMFLEX AND DOT BELOW › LATIN SMALL LETTER A
                    case '\u1EAF':
                        sb.Append('\u0061');
                        break; //  ? › a    LATIN SMALL LETTER A WITH BREVE AND ACUTE › LATIN SMALL LETTER A
                    case '\u1EB1':
                        sb.Append('\u0061');
                        break; //  ? › a    LATIN SMALL LETTER A WITH BREVE AND GRAVE › LATIN SMALL LETTER A
                    case '\u1EB3':
                        sb.Append('\u0061');
                        break; //  ? › a    LATIN SMALL LETTER A WITH BREVE AND HOOK ABOVE › LATIN SMALL LETTER A
                    case '\u1EB5':
                        sb.Append('\u0061');
                        break; //  ? › a    LATIN SMALL LETTER A WITH BREVE AND TILDE › LATIN SMALL LETTER A
                    case '\u1EB7':
                        sb.Append('\u0061');
                        break; //  ? › a    LATIN SMALL LETTER A WITH BREVE AND DOT BELOW › LATIN SMALL LETTER A
                    case '\u0180':
                        sb.Append('\u0062');
                        break; //  b › b    LATIN SMALL LETTER B WITH STROKE › LATIN SMALL LETTER B
                    case '\u0183':
                        sb.Append('\u0062');
                        break; //  ? › b    LATIN SMALL LETTER B WITH TOPBAR › LATIN SMALL LETTER B
                    case '\u0253':
                        sb.Append('\u0062');
                        break; //  ? › b    LATIN SMALL LETTER B WITH HOOK › LATIN SMALL LETTER B
                    case '\u1E03':
                        sb.Append('\u0062');
                        break; //  ? › b    LATIN SMALL LETTER B WITH DOT ABOVE › LATIN SMALL LETTER B
                    case '\u1E05':
                        sb.Append('\u0062');
                        break; //  ? › b    LATIN SMALL LETTER B WITH DOT BELOW › LATIN SMALL LETTER B
                    case '\u1E07':
                        sb.Append('\u0062');
                        break; //  ? › b    LATIN SMALL LETTER B WITH LINE BELOW › LATIN SMALL LETTER B
                    case '\u00E7':
                        sb.Append('\u0063');
                        break; //  ç › c    LATIN SMALL LETTER C WITH CEDILLA › LATIN SMALL LETTER C
                    case '\u0107':
                        sb.Append('\u0063');
                        break; //  ć › c    LATIN SMALL LETTER C WITH ACUTE › LATIN SMALL LETTER C
                    case '\u0109':
                        sb.Append('\u0063');
                        break; //  c › c    LATIN SMALL LETTER C WITH CIRCUMFLEX › LATIN SMALL LETTER C
                    case '\u010B':
                        sb.Append('\u0063');
                        break; //  c › c    LATIN SMALL LETTER C WITH DOT ABOVE › LATIN SMALL LETTER C
                    case '\u010D':
                        sb.Append('\u0063');
                        break; //  č › c    LATIN SMALL LETTER C WITH CARON › LATIN SMALL LETTER C
                    case '\u0188':
                        sb.Append('\u0063');
                        break; //  ? › c    LATIN SMALL LETTER C WITH HOOK › LATIN SMALL LETTER C
                    case '\u0255':
                        sb.Append('\u0063');
                        break; //  ? › c    LATIN SMALL LETTER C WITH CURL › LATIN SMALL LETTER C
                    case '\u1E09':
                        sb.Append('\u0063');
                        break; //  ? › c    LATIN SMALL LETTER C WITH CEDILLA AND ACUTE › LATIN SMALL LETTER C
                    case '\u010F':
                        sb.Append('\u0064');
                        break; //  ď › d    LATIN SMALL LETTER D WITH CARON › LATIN SMALL LETTER D
                    case '\u0111':
                        sb.Append('\u0064');
                        break; //  đ › d    LATIN SMALL LETTER D WITH STROKE › LATIN SMALL LETTER D
                    case '\u018C':
                        sb.Append('\u0064');
                        break; //  ? › d    LATIN SMALL LETTER D WITH TOPBAR › LATIN SMALL LETTER D
                    case '\u0221':
                        sb.Append('\u0064');
                        break; //  ? › d    LATIN SMALL LETTER D WITH CURL › LATIN SMALL LETTER D
                    case '\u0256':
                        sb.Append('\u0064');
                        break; //  ? › d    LATIN SMALL LETTER D WITH TAIL › LATIN SMALL LETTER D
                    case '\u0257':
                        sb.Append('\u0064');
                        break; //  ? › d    LATIN SMALL LETTER D WITH HOOK › LATIN SMALL LETTER D
                    case '\u1E0B':
                        sb.Append('\u0064');
                        break; //  ? › d    LATIN SMALL LETTER D WITH DOT ABOVE › LATIN SMALL LETTER D
                    case '\u1E0D':
                        sb.Append('\u0064');
                        break; //  ? › d    LATIN SMALL LETTER D WITH DOT BELOW › LATIN SMALL LETTER D
                    case '\u1E0F':
                        sb.Append('\u0064');
                        break; //  ? › d    LATIN SMALL LETTER D WITH LINE BELOW › LATIN SMALL LETTER D
                    case '\u1E11':
                        sb.Append('\u0064');
                        break; //  ? › d    LATIN SMALL LETTER D WITH CEDILLA › LATIN SMALL LETTER D
                    case '\u1E13':
                        sb.Append('\u0064');
                        break; //  ? › d    LATIN SMALL LETTER D WITH CIRCUMFLEX BELOW › LATIN SMALL LETTER D
                    case '\u00E8':
                        sb.Append('\u0065');
                        break; //  e › e    LATIN SMALL LETTER E WITH GRAVE › LATIN SMALL LETTER E
                    case '\u00E9':
                        sb.Append('\u0065');
                        break; //  é › e    LATIN SMALL LETTER E WITH ACUTE › LATIN SMALL LETTER E
                    case '\u00EA':
                        sb.Append('\u0065');
                        break; //  e › e    LATIN SMALL LETTER E WITH CIRCUMFLEX › LATIN SMALL LETTER E
                    case '\u00EB':
                        sb.Append('\u0065');
                        break; //  ë › e    LATIN SMALL LETTER E WITH DIAERESIS › LATIN SMALL LETTER E
                    case '\u0113':
                        sb.Append('\u0065');
                        break; //  e › e    LATIN SMALL LETTER E WITH MACRON › LATIN SMALL LETTER E
                    case '\u0115':
                        sb.Append('\u0065');
                        break; //  e › e    LATIN SMALL LETTER E WITH BREVE › LATIN SMALL LETTER E
                    case '\u0117':
                        sb.Append('\u0065');
                        break; //  e › e    LATIN SMALL LETTER E WITH DOT ABOVE › LATIN SMALL LETTER E
                    case '\u0119':
                        sb.Append('\u0065');
                        break; //  ę › e    LATIN SMALL LETTER E WITH OGONEK › LATIN SMALL LETTER E
                    case '\u011B':
                        sb.Append('\u0065');
                        break; //  ě › e    LATIN SMALL LETTER E WITH CARON › LATIN SMALL LETTER E
                    case '\u0205':
                        sb.Append('\u0065');
                        break; //  ? › e    LATIN SMALL LETTER E WITH DOUBLE GRAVE › LATIN SMALL LETTER E
                    case '\u0207':
                        sb.Append('\u0065');
                        break; //  ? › e    LATIN SMALL LETTER E WITH INVERTED BREVE › LATIN SMALL LETTER E
                    case '\u0229':
                        sb.Append('\u0065');
                        break; //  ? › e    LATIN SMALL LETTER E WITH CEDILLA › LATIN SMALL LETTER E
                    case '\u1E15':
                        sb.Append('\u0065');
                        break; //  ? › e    LATIN SMALL LETTER E WITH MACRON AND GRAVE › LATIN SMALL LETTER E
                    case '\u1E17':
                        sb.Append('\u0065');
                        break; //  ? › e    LATIN SMALL LETTER E WITH MACRON AND ACUTE › LATIN SMALL LETTER E
                    case '\u1E19':
                        sb.Append('\u0065');
                        break; //  ? › e    LATIN SMALL LETTER E WITH CIRCUMFLEX BELOW › LATIN SMALL LETTER E
                    case '\u1E1B':
                        sb.Append('\u0065');
                        break; //  ? › e    LATIN SMALL LETTER E WITH TILDE BELOW › LATIN SMALL LETTER E
                    case '\u1E1D':
                        sb.Append('\u0065');
                        break; //  ? › e    LATIN SMALL LETTER E WITH CEDILLA AND BREVE › LATIN SMALL LETTER E
                    case '\u1EB9':
                        sb.Append('\u0065');
                        break; //  ? › e    LATIN SMALL LETTER E WITH DOT BELOW › LATIN SMALL LETTER E
                    case '\u1EBB':
                        sb.Append('\u0065');
                        break; //  ? › e    LATIN SMALL LETTER E WITH HOOK ABOVE › LATIN SMALL LETTER E
                    case '\u1EBD':
                        sb.Append('\u0065');
                        break; //  ? › e    LATIN SMALL LETTER E WITH TILDE › LATIN SMALL LETTER E
                    case '\u1EBF':
                        sb.Append('\u0065');
                        break; //  ? › e    LATIN SMALL LETTER E WITH CIRCUMFLEX AND ACUTE › LATIN SMALL LETTER E
                    case '\u1EC1':
                        sb.Append('\u0065');
                        break; //  ? › e    LATIN SMALL LETTER E WITH CIRCUMFLEX AND GRAVE › LATIN SMALL LETTER E
                    case '\u1EC3':
                        sb.Append('\u0065');
                        break; //  ? › e    LATIN SMALL LETTER E WITH CIRCUMFLEX AND HOOK ABOVE › LATIN SMALL LETTER E
                    case '\u1EC5':
                        sb.Append('\u0065');
                        break; //  ? › e    LATIN SMALL LETTER E WITH CIRCUMFLEX AND TILDE › LATIN SMALL LETTER E
                    case '\u1EC7':
                        sb.Append('\u0065');
                        break; //  ? › e    LATIN SMALL LETTER E WITH CIRCUMFLEX AND DOT BELOW › LATIN SMALL LETTER E
                    case '\u0192':
                        sb.Append('\u0066');
                        break; //  f › f    LATIN SMALL LETTER F WITH HOOK › LATIN SMALL LETTER F
                    case '\u1E1F':
                        sb.Append('\u0066');
                        break; //  ? › f    LATIN SMALL LETTER F WITH DOT ABOVE › LATIN SMALL LETTER F
                    case '\u011D':
                        sb.Append('\u0067');
                        break; //  g › g    LATIN SMALL LETTER G WITH CIRCUMFLEX › LATIN SMALL LETTER G
                    case '\u011F':
                        sb.Append('\u0067');
                        break; //  g › g    LATIN SMALL LETTER G WITH BREVE › LATIN SMALL LETTER G
                    case '\u0121':
                        sb.Append('\u0067');
                        break; //  g › g    LATIN SMALL LETTER G WITH DOT ABOVE › LATIN SMALL LETTER G
                    case '\u0123':
                        sb.Append('\u0067');
                        break; //  g › g    LATIN SMALL LETTER G WITH CEDILLA › LATIN SMALL LETTER G
                    case '\u01E5':
                        sb.Append('\u0067');
                        break; //  g › g    LATIN SMALL LETTER G WITH STROKE › LATIN SMALL LETTER G
                    case '\u01E7':
                        sb.Append('\u0067');
                        break; //  g › g    LATIN SMALL LETTER G WITH CARON › LATIN SMALL LETTER G
                    case '\u01F5':
                        sb.Append('\u0067');
                        break; //  ? › g    LATIN SMALL LETTER G WITH ACUTE › LATIN SMALL LETTER G
                    case '\u0260':
                        sb.Append('\u0067');
                        break; //  ? › g    LATIN SMALL LETTER G WITH HOOK › LATIN SMALL LETTER G
                    case '\u1E21':
                        sb.Append('\u0067');
                        break; //  ? › g    LATIN SMALL LETTER G WITH MACRON › LATIN SMALL LETTER G
                    case '\u0125':
                        sb.Append('\u0068');
                        break; //  h › h    LATIN SMALL LETTER H WITH CIRCUMFLEX › LATIN SMALL LETTER H
                    case '\u0127':
                        sb.Append('\u0068');
                        break; //  h › h    LATIN SMALL LETTER H WITH STROKE › LATIN SMALL LETTER H
                    case '\u021F':
                        sb.Append('\u0068');
                        break; //  ? › h    LATIN SMALL LETTER H WITH CARON › LATIN SMALL LETTER H
                    case '\u0266':
                        sb.Append('\u0068');
                        break; //  ? › h    LATIN SMALL LETTER H WITH HOOK › LATIN SMALL LETTER H
                    case '\u1E23':
                        sb.Append('\u0068');
                        break; //  ? › h    LATIN SMALL LETTER H WITH DOT ABOVE › LATIN SMALL LETTER H
                    case '\u1E25':
                        sb.Append('\u0068');
                        break; //  ? › h    LATIN SMALL LETTER H WITH DOT BELOW › LATIN SMALL LETTER H
                    case '\u1E27':
                        sb.Append('\u0068');
                        break; //  ? › h    LATIN SMALL LETTER H WITH DIAERESIS › LATIN SMALL LETTER H
                    case '\u1E29':
                        sb.Append('\u0068');
                        break; //  ? › h    LATIN SMALL LETTER H WITH CEDILLA › LATIN SMALL LETTER H
                    case '\u1E2B':
                        sb.Append('\u0068');
                        break; //  ? › h    LATIN SMALL LETTER H WITH BREVE BELOW › LATIN SMALL LETTER H
                    case '\u1E96':
                        sb.Append('\u0068');
                        break; //  ? › h    LATIN SMALL LETTER H WITH LINE BELOW › LATIN SMALL LETTER H
                    case '\u00EC':
                        sb.Append('\u0069');
                        break; //  i › i    LATIN SMALL LETTER I WITH GRAVE › LATIN SMALL LETTER I
                    case '\u00ED':
                        sb.Append('\u0069');
                        break; //  í › i    LATIN SMALL LETTER I WITH ACUTE › LATIN SMALL LETTER I
                    case '\u00EE':
                        sb.Append('\u0069');
                        break; //  î › i    LATIN SMALL LETTER I WITH CIRCUMFLEX › LATIN SMALL LETTER I
                    case '\u00EF':
                        sb.Append('\u0069');
                        break; //  i › i    LATIN SMALL LETTER I WITH DIAERESIS › LATIN SMALL LETTER I
                    case '\u0129':
                        sb.Append('\u0069');
                        break; //  i › i    LATIN SMALL LETTER I WITH TILDE › LATIN SMALL LETTER I
                    case '\u012B':
                        sb.Append('\u0069');
                        break; //  i › i    LATIN SMALL LETTER I WITH MACRON › LATIN SMALL LETTER I
                    case '\u012D':
                        sb.Append('\u0069');
                        break; //  i › i    LATIN SMALL LETTER I WITH BREVE › LATIN SMALL LETTER I
                    case '\u012F':
                        sb.Append('\u0069');
                        break; //  i › i    LATIN SMALL LETTER I WITH OGONEK › LATIN SMALL LETTER I
                    case '\u01D0':
                        sb.Append('\u0069');
                        break; //  i › i    LATIN SMALL LETTER I WITH CARON › LATIN SMALL LETTER I
                    case '\u0209':
                        sb.Append('\u0069');
                        break; //  ? › i    LATIN SMALL LETTER I WITH DOUBLE GRAVE › LATIN SMALL LETTER I
                    case '\u020B':
                        sb.Append('\u0069');
                        break; //  ? › i    LATIN SMALL LETTER I WITH INVERTED BREVE › LATIN SMALL LETTER I
                    case '\u0268':
                        sb.Append('\u0069');
                        break; //  ? › i    LATIN SMALL LETTER I WITH STROKE › LATIN SMALL LETTER I
                    case '\u1E2D':
                        sb.Append('\u0069');
                        break; //  ? › i    LATIN SMALL LETTER I WITH TILDE BELOW › LATIN SMALL LETTER I
                    case '\u1E2F':
                        sb.Append('\u0069');
                        break; //  ? › i    LATIN SMALL LETTER I WITH DIAERESIS AND ACUTE › LATIN SMALL LETTER I
                    case '\u1EC9':
                        sb.Append('\u0069');
                        break; //  ? › i    LATIN SMALL LETTER I WITH HOOK ABOVE › LATIN SMALL LETTER I
                    case '\u1ECB':
                        sb.Append('\u0069');
                        break; //  ? › i    LATIN SMALL LETTER I WITH DOT BELOW › LATIN SMALL LETTER I
                    case '\u0135':
                        sb.Append('\u006A');
                        break; //  j › j    LATIN SMALL LETTER J WITH CIRCUMFLEX › LATIN SMALL LETTER J
                    case '\u01F0':
                        sb.Append('\u006A');
                        break; //  j › j    LATIN SMALL LETTER J WITH CARON › LATIN SMALL LETTER J
                    case '\u029D':
                        sb.Append('\u006A');
                        break; //  ? › j    LATIN SMALL LETTER J WITH CROSSED-TAIL › LATIN SMALL LETTER J
                    case '\u0137':
                        sb.Append('\u006B');
                        break; //  k › k    LATIN SMALL LETTER K WITH CEDILLA › LATIN SMALL LETTER K
                    case '\u0199':
                        sb.Append('\u006B');
                        break; //  ? › k    LATIN SMALL LETTER K WITH HOOK › LATIN SMALL LETTER K
                    case '\u01E9':
                        sb.Append('\u006B');
                        break; //  k › k    LATIN SMALL LETTER K WITH CARON › LATIN SMALL LETTER K
                    case '\u1E31':
                        sb.Append('\u006B');
                        break; //  ? › k    LATIN SMALL LETTER K WITH ACUTE › LATIN SMALL LETTER K
                    case '\u1E33':
                        sb.Append('\u006B');
                        break; //  ? › k    LATIN SMALL LETTER K WITH DOT BELOW › LATIN SMALL LETTER K
                    case '\u1E35':
                        sb.Append('\u006B');
                        break; //  ? › k    LATIN SMALL LETTER K WITH LINE BELOW › LATIN SMALL LETTER K
                    case '\u013A':
                        sb.Append('\u006C');
                        break; //  ĺ › l    LATIN SMALL LETTER L WITH ACUTE › LATIN SMALL LETTER L
                    case '\u013C':
                        sb.Append('\u006C');
                        break; //  l › l    LATIN SMALL LETTER L WITH CEDILLA › LATIN SMALL LETTER L
                    case '\u013E':
                        sb.Append('\u006C');
                        break; //  ľ › l    LATIN SMALL LETTER L WITH CARON › LATIN SMALL LETTER L
                    case '\u0140':
                        sb.Append('\u006C');
                        break; //  ? › l    LATIN SMALL LETTER L WITH MIDDLE DOT › LATIN SMALL LETTER L
                    case '\u0142':
                        sb.Append('\u006C');
                        break; //  ł › l    LATIN SMALL LETTER L WITH STROKE › LATIN SMALL LETTER L
                    case '\u019A':
                        sb.Append('\u006C');
                        break; //  l › l    LATIN SMALL LETTER L WITH BAR › LATIN SMALL LETTER L
                    case '\u0234':
                        sb.Append('\u006C');
                        break; //  ? › l    LATIN SMALL LETTER L WITH CURL › LATIN SMALL LETTER L
                    case '\u026B':
                        sb.Append('\u006C');
                        break; //  ? › l    LATIN SMALL LETTER L WITH MIDDLE TILDE › LATIN SMALL LETTER L
                    case '\u026C':
                        sb.Append('\u006C');
                        break; //  ? › l    LATIN SMALL LETTER L WITH BELT › LATIN SMALL LETTER L
                    case '\u026D':
                        sb.Append('\u006C');
                        break; //  ? › l    LATIN SMALL LETTER L WITH RETROFLEX HOOK › LATIN SMALL LETTER L
                    case '\u1E37':
                        sb.Append('\u006C');
                        break; //  ? › l    LATIN SMALL LETTER L WITH DOT BELOW › LATIN SMALL LETTER L
                    case '\u1E39':
                        sb.Append('\u006C');
                        break; //  ? › l    LATIN SMALL LETTER L WITH DOT BELOW AND MACRON › LATIN SMALL LETTER L
                    case '\u1E3B':
                        sb.Append('\u006C');
                        break; //  ? › l    LATIN SMALL LETTER L WITH LINE BELOW › LATIN SMALL LETTER L
                    case '\u1E3D':
                        sb.Append('\u006C');
                        break; //  ? › l    LATIN SMALL LETTER L WITH CIRCUMFLEX BELOW › LATIN SMALL LETTER L
                    case '\u0271':
                        sb.Append('\u006D');
                        break; //  ? › m    LATIN SMALL LETTER M WITH HOOK › LATIN SMALL LETTER M
                    case '\u1E3F':
                        sb.Append('\u006D');
                        break; //  ? › m    LATIN SMALL LETTER M WITH ACUTE › LATIN SMALL LETTER M
                    case '\u1E41':
                        sb.Append('\u006D');
                        break; //  ? › m    LATIN SMALL LETTER M WITH DOT ABOVE › LATIN SMALL LETTER M
                    case '\u1E43':
                        sb.Append('\u006D');
                        break; //  ? › m    LATIN SMALL LETTER M WITH DOT BELOW › LATIN SMALL LETTER M
                    case '\u00F1':
                        sb.Append('\u006E');
                        break; //  n › n    LATIN SMALL LETTER N WITH TILDE › LATIN SMALL LETTER N
                    case '\u0144':
                        sb.Append('\u006E');
                        break; //  ń › n    LATIN SMALL LETTER N WITH ACUTE › LATIN SMALL LETTER N
                    case '\u0146':
                        sb.Append('\u006E');
                        break; //  n › n    LATIN SMALL LETTER N WITH CEDILLA › LATIN SMALL LETTER N
                    case '\u0148':
                        sb.Append('\u006E');
                        break; //  ň › n    LATIN SMALL LETTER N WITH CARON › LATIN SMALL LETTER N
                    case '\u019E':
                        sb.Append('\u006E');
                        break; //  ? › n    LATIN SMALL LETTER N WITH LONG RIGHT LEG › LATIN SMALL LETTER N
                    case '\u01F9':
                        sb.Append('\u006E');
                        break; //  ? › n    LATIN SMALL LETTER N WITH GRAVE › LATIN SMALL LETTER N
                    case '\u0235':
                        sb.Append('\u006E');
                        break; //  ? › n    LATIN SMALL LETTER N WITH CURL › LATIN SMALL LETTER N
                    case '\u0272':
                        sb.Append('\u006E');
                        break; //  ? › n    LATIN SMALL LETTER N WITH LEFT HOOK › LATIN SMALL LETTER N
                    case '\u0273':
                        sb.Append('\u006E');
                        break; //  ? › n    LATIN SMALL LETTER N WITH RETROFLEX HOOK › LATIN SMALL LETTER N
                    case '\u1E45':
                        sb.Append('\u006E');
                        break; //  ? › n    LATIN SMALL LETTER N WITH DOT ABOVE › LATIN SMALL LETTER N
                    case '\u1E47':
                        sb.Append('\u006E');
                        break; //  ? › n    LATIN SMALL LETTER N WITH DOT BELOW › LATIN SMALL LETTER N
                    case '\u1E49':
                        sb.Append('\u006E');
                        break; //  ? › n    LATIN SMALL LETTER N WITH LINE BELOW › LATIN SMALL LETTER N
                    case '\u1E4B':
                        sb.Append('\u006E');
                        break; //  ? › n    LATIN SMALL LETTER N WITH CIRCUMFLEX BELOW › LATIN SMALL LETTER N
                    case '\u00F2':
                        sb.Append('\u006F');
                        break; //  o › o    LATIN SMALL LETTER O WITH GRAVE › LATIN SMALL LETTER O
                    case '\u00F3':
                        sb.Append('\u006F');
                        break; //  ó › o    LATIN SMALL LETTER O WITH ACUTE › LATIN SMALL LETTER O
                    case '\u00F4':
                        sb.Append('\u006F');
                        break; //  ô › o    LATIN SMALL LETTER O WITH CIRCUMFLEX › LATIN SMALL LETTER O
                    case '\u00F5':
                        sb.Append('\u006F');
                        break; //  o › o    LATIN SMALL LETTER O WITH TILDE › LATIN SMALL LETTER O
                    case '\u00F6':
                        sb.Append('\u006F');
                        break; //  ö › o    LATIN SMALL LETTER O WITH DIAERESIS › LATIN SMALL LETTER O
                    case '\u00F8':
                        sb.Append('\u006F');
                        break; //  o › o    LATIN SMALL LETTER O WITH STROKE › LATIN SMALL LETTER O
                    case '\u014D':
                        sb.Append('\u006F');
                        break; //  o › o    LATIN SMALL LETTER O WITH MACRON › LATIN SMALL LETTER O
                    case '\u014F':
                        sb.Append('\u006F');
                        break; //  o › o    LATIN SMALL LETTER O WITH BREVE › LATIN SMALL LETTER O
                    case '\u0151':
                        sb.Append('\u006F');
                        break; //  ő › o    LATIN SMALL LETTER O WITH DOUBLE ACUTE › LATIN SMALL LETTER O
                    case '\u01A1':
                        sb.Append('\u006F');
                        break; //  o › o    LATIN SMALL LETTER O WITH HORN › LATIN SMALL LETTER O
                    case '\u01D2':
                        sb.Append('\u006F');
                        break; //  o › o    LATIN SMALL LETTER O WITH CARON › LATIN SMALL LETTER O
                    case '\u01EB':
                        sb.Append('\u006F');
                        break; //  o › o    LATIN SMALL LETTER O WITH OGONEK › LATIN SMALL LETTER O
                    case '\u01ED':
                        sb.Append('\u006F');
                        break; //  o › o    LATIN SMALL LETTER O WITH OGONEK AND MACRON › LATIN SMALL LETTER O
                    case '\u01FF':
                        sb.Append('\u006F');
                        break; //  ? › o    LATIN SMALL LETTER O WITH STROKE AND ACUTE › LATIN SMALL LETTER O
                    case '\u020D':
                        sb.Append('\u006F');
                        break; //  ? › o    LATIN SMALL LETTER O WITH DOUBLE GRAVE › LATIN SMALL LETTER O
                    case '\u020F':
                        sb.Append('\u006F');
                        break; //  ? › o    LATIN SMALL LETTER O WITH INVERTED BREVE › LATIN SMALL LETTER O
                    case '\u022B':
                        sb.Append('\u006F');
                        break; //  ? › o    LATIN SMALL LETTER O WITH DIAERESIS AND MACRON › LATIN SMALL LETTER O
                    case '\u022D':
                        sb.Append('\u006F');
                        break; //  ? › o    LATIN SMALL LETTER O WITH TILDE AND MACRON › LATIN SMALL LETTER O
                    case '\u022F':
                        sb.Append('\u006F');
                        break; //  ? › o    LATIN SMALL LETTER O WITH DOT ABOVE › LATIN SMALL LETTER O
                    case '\u0231':
                        sb.Append('\u006F');
                        break; //  ? › o    LATIN SMALL LETTER O WITH DOT ABOVE AND MACRON › LATIN SMALL LETTER O
                    case '\u1E4D':
                        sb.Append('\u006F');
                        break; //  ? › o    LATIN SMALL LETTER O WITH TILDE AND ACUTE › LATIN SMALL LETTER O
                    case '\u1E4F':
                        sb.Append('\u006F');
                        break; //  ? › o    LATIN SMALL LETTER O WITH TILDE AND DIAERESIS › LATIN SMALL LETTER O
                    case '\u1E51':
                        sb.Append('\u006F');
                        break; //  ? › o    LATIN SMALL LETTER O WITH MACRON AND GRAVE › LATIN SMALL LETTER O
                    case '\u1E53':
                        sb.Append('\u006F');
                        break; //  ? › o    LATIN SMALL LETTER O WITH MACRON AND ACUTE › LATIN SMALL LETTER O
                    case '\u1ECD':
                        sb.Append('\u006F');
                        break; //  ? › o    LATIN SMALL LETTER O WITH DOT BELOW › LATIN SMALL LETTER O
                    case '\u1ECF':
                        sb.Append('\u006F');
                        break; //  ? › o    LATIN SMALL LETTER O WITH HOOK ABOVE › LATIN SMALL LETTER O
                    case '\u1ED1':
                        sb.Append('\u006F');
                        break; //  ? › o    LATIN SMALL LETTER O WITH CIRCUMFLEX AND ACUTE › LATIN SMALL LETTER O
                    case '\u1ED3':
                        sb.Append('\u006F');
                        break; //  ? › o    LATIN SMALL LETTER O WITH CIRCUMFLEX AND GRAVE › LATIN SMALL LETTER O
                    case '\u1ED5':
                        sb.Append('\u006F');
                        break; //  ? › o    LATIN SMALL LETTER O WITH CIRCUMFLEX AND HOOK ABOVE › LATIN SMALL LETTER O
                    case '\u1ED7':
                        sb.Append('\u006F');
                        break; //  ? › o    LATIN SMALL LETTER O WITH CIRCUMFLEX AND TILDE › LATIN SMALL LETTER O
                    case '\u1ED9':
                        sb.Append('\u006F');
                        break; //  ? › o    LATIN SMALL LETTER O WITH CIRCUMFLEX AND DOT BELOW › LATIN SMALL LETTER O
                    case '\u1EDB':
                        sb.Append('\u006F');
                        break; //  ? › o    LATIN SMALL LETTER O WITH HORN AND ACUTE › LATIN SMALL LETTER O
                    case '\u1EDD':
                        sb.Append('\u006F');
                        break; //  ? › o    LATIN SMALL LETTER O WITH HORN AND GRAVE › LATIN SMALL LETTER O
                    case '\u1EDF':
                        sb.Append('\u006F');
                        break; //  ? › o    LATIN SMALL LETTER O WITH HORN AND HOOK ABOVE › LATIN SMALL LETTER O
                    case '\u1EE1':
                        sb.Append('\u006F');
                        break; //  ? › o    LATIN SMALL LETTER O WITH HORN AND TILDE › LATIN SMALL LETTER O
                    case '\u1EE3':
                        sb.Append('\u006F');
                        break; //  ? › o    LATIN SMALL LETTER O WITH HORN AND DOT BELOW › LATIN SMALL LETTER O
                    case '\u01A5':
                        sb.Append('\u0070');
                        break; //  ? › p    LATIN SMALL LETTER P WITH HOOK › LATIN SMALL LETTER P
                    case '\u1E55':
                        sb.Append('\u0070');
                        break; //  ? › p    LATIN SMALL LETTER P WITH ACUTE › LATIN SMALL LETTER P
                    case '\u1E57':
                        sb.Append('\u0070');
                        break; //  ? › p    LATIN SMALL LETTER P WITH DOT ABOVE › LATIN SMALL LETTER P
                    case '\u02A0':
                        sb.Append('\u0071');
                        break; //  ? › q    LATIN SMALL LETTER Q WITH HOOK › LATIN SMALL LETTER Q
                    case '\u0155':
                        sb.Append('\u0072');
                        break; //  ŕ › r    LATIN SMALL LETTER R WITH ACUTE › LATIN SMALL LETTER R
                    case '\u0157':
                        sb.Append('\u0072');
                        break; //  r › r    LATIN SMALL LETTER R WITH CEDILLA › LATIN SMALL LETTER R
                    case '\u0159':
                        sb.Append('\u0072');
                        break; //  ř › r    LATIN SMALL LETTER R WITH CARON › LATIN SMALL LETTER R
                    case '\u0211':
                        sb.Append('\u0072');
                        break; //  ? › r    LATIN SMALL LETTER R WITH DOUBLE GRAVE › LATIN SMALL LETTER R
                    case '\u0213':
                        sb.Append('\u0072');
                        break; //  ? › r    LATIN SMALL LETTER R WITH INVERTED BREVE › LATIN SMALL LETTER R
                    case '\u027C':
                        sb.Append('\u0072');
                        break; //  ? › r    LATIN SMALL LETTER R WITH LONG LEG › LATIN SMALL LETTER R
                    case '\u027D':
                        sb.Append('\u0072');
                        break; //  ? › r    LATIN SMALL LETTER R WITH TAIL › LATIN SMALL LETTER R
                    case '\u1E59':
                        sb.Append('\u0072');
                        break; //  ? › r    LATIN SMALL LETTER R WITH DOT ABOVE › LATIN SMALL LETTER R
                    case '\u1E5B':
                        sb.Append('\u0072');
                        break; //  ? › r    LATIN SMALL LETTER R WITH DOT BELOW › LATIN SMALL LETTER R
                    case '\u1E5D':
                        sb.Append('\u0072');
                        break; //  ? › r    LATIN SMALL LETTER R WITH DOT BELOW AND MACRON › LATIN SMALL LETTER R
                    case '\u1E5F':
                        sb.Append('\u0072');
                        break; //  ? › r    LATIN SMALL LETTER R WITH LINE BELOW › LATIN SMALL LETTER R
                    case '\u015B':
                        sb.Append('\u0073');
                        break; //  ś › s    LATIN SMALL LETTER S WITH ACUTE › LATIN SMALL LETTER S
                    case '\u015D':
                        sb.Append('\u0073');
                        break; //  s › s    LATIN SMALL LETTER S WITH CIRCUMFLEX › LATIN SMALL LETTER S
                    case '\u015F':
                        sb.Append('\u0073');
                        break; //  ş › s    LATIN SMALL LETTER S WITH CEDILLA › LATIN SMALL LETTER S
                    case '\u0161':
                        sb.Append('\u0073');
                        break; //  š › s    LATIN SMALL LETTER S WITH CARON › LATIN SMALL LETTER S
                    case '\u0219':
                        sb.Append('\u0073');
                        break; //  ? › s    LATIN SMALL LETTER S WITH COMMA BELOW › LATIN SMALL LETTER S
                    case '\u0282':
                        sb.Append('\u0073');
                        break; //  ? › s    LATIN SMALL LETTER S WITH HOOK › LATIN SMALL LETTER S
                    case '\u1E61':
                        sb.Append('\u0073');
                        break; //  ? › s    LATIN SMALL LETTER S WITH DOT ABOVE › LATIN SMALL LETTER S
                    case '\u1E63':
                        sb.Append('\u0073');
                        break; //  ? › s    LATIN SMALL LETTER S WITH DOT BELOW › LATIN SMALL LETTER S
                    case '\u1E65':
                        sb.Append('\u0073');
                        break; //  ? › s    LATIN SMALL LETTER S WITH ACUTE AND DOT ABOVE › LATIN SMALL LETTER S
                    case '\u1E67':
                        sb.Append('\u0073');
                        break; //  ? › s    LATIN SMALL LETTER S WITH CARON AND DOT ABOVE › LATIN SMALL LETTER S
                    case '\u1E69':
                        sb.Append('\u0073');
                        break; //  ? › s    LATIN SMALL LETTER S WITH DOT BELOW AND DOT ABOVE › LATIN SMALL LETTER S
                    case '\u0163':
                        sb.Append('\u0074');
                        break; //  ţ › t    LATIN SMALL LETTER T WITH CEDILLA › LATIN SMALL LETTER T
                    case '\u0165':
                        sb.Append('\u0074');
                        break; //  ť › t    LATIN SMALL LETTER T WITH CARON › LATIN SMALL LETTER T
                    case '\u0167':
                        sb.Append('\u0074');
                        break; //  t › t    LATIN SMALL LETTER T WITH STROKE › LATIN SMALL LETTER T
                    case '\u01AB':
                        sb.Append('\u0074');
                        break; //  t › t    LATIN SMALL LETTER T WITH PALATAL HOOK › LATIN SMALL LETTER T
                    case '\u01AD':
                        sb.Append('\u0074');
                        break; //  ? › t    LATIN SMALL LETTER T WITH HOOK › LATIN SMALL LETTER T
                    case '\u021B':
                        sb.Append('\u0074');
                        break; //  ? › t    LATIN SMALL LETTER T WITH COMMA BELOW › LATIN SMALL LETTER T
                    case '\u0236':
                        sb.Append('\u0074');
                        break; //  ? › t    LATIN SMALL LETTER T WITH CURL › LATIN SMALL LETTER T
                    case '\u0288':
                        sb.Append('\u0074');
                        break; //  ? › t    LATIN SMALL LETTER T WITH RETROFLEX HOOK › LATIN SMALL LETTER T
                    case '\u1E6B':
                        sb.Append('\u0074');
                        break; //  ? › t    LATIN SMALL LETTER T WITH DOT ABOVE › LATIN SMALL LETTER T
                    case '\u1E6D':
                        sb.Append('\u0074');
                        break; //  ? › t    LATIN SMALL LETTER T WITH DOT BELOW › LATIN SMALL LETTER T
                    case '\u1E6F':
                        sb.Append('\u0074');
                        break; //  ? › t    LATIN SMALL LETTER T WITH LINE BELOW › LATIN SMALL LETTER T
                    case '\u1E71':
                        sb.Append('\u0074');
                        break; //  ? › t    LATIN SMALL LETTER T WITH CIRCUMFLEX BELOW › LATIN SMALL LETTER T
                    case '\u1E97':
                        sb.Append('\u0074');
                        break; //  ? › t    LATIN SMALL LETTER T WITH DIAERESIS › LATIN SMALL LETTER T
                    case '\u00F9':
                        sb.Append('\u0075');
                        break; //  u › u    LATIN SMALL LETTER U WITH GRAVE › LATIN SMALL LETTER U
                    case '\u00FA':
                        sb.Append('\u0075');
                        break; //  ú › u    LATIN SMALL LETTER U WITH ACUTE › LATIN SMALL LETTER U
                    case '\u00FB':
                        sb.Append('\u0075');
                        break; //  u › u    LATIN SMALL LETTER U WITH CIRCUMFLEX › LATIN SMALL LETTER U
                    case '\u00FC':
                        sb.Append('\u0075');
                        break; //  ü › u    LATIN SMALL LETTER U WITH DIAERESIS › LATIN SMALL LETTER U
                    case '\u0169':
                        sb.Append('\u0075');
                        break; //  u › u    LATIN SMALL LETTER U WITH TILDE › LATIN SMALL LETTER U
                    case '\u016B':
                        sb.Append('\u0075');
                        break; //  u › u    LATIN SMALL LETTER U WITH MACRON › LATIN SMALL LETTER U
                    case '\u016D':
                        sb.Append('\u0075');
                        break; //  u › u    LATIN SMALL LETTER U WITH BREVE › LATIN SMALL LETTER U
                    case '\u016F':
                        sb.Append('\u0075');
                        break; //  ů › u    LATIN SMALL LETTER U WITH RING ABOVE › LATIN SMALL LETTER U
                    case '\u0171':
                        sb.Append('\u0075');
                        break; //  ű › u    LATIN SMALL LETTER U WITH DOUBLE ACUTE › LATIN SMALL LETTER U
                    case '\u0173':
                        sb.Append('\u0075');
                        break; //  u › u    LATIN SMALL LETTER U WITH OGONEK › LATIN SMALL LETTER U
                    case '\u01B0':
                        sb.Append('\u0075');
                        break; //  u › u    LATIN SMALL LETTER U WITH HORN › LATIN SMALL LETTER U
                    case '\u01D4':
                        sb.Append('\u0075');
                        break; //  u › u    LATIN SMALL LETTER U WITH CARON › LATIN SMALL LETTER U
                    case '\u01D6':
                        sb.Append('\u0075');
                        break; //  u › u    LATIN SMALL LETTER U WITH DIAERESIS AND MACRON › LATIN SMALL LETTER U
                    case '\u01D8':
                        sb.Append('\u0075');
                        break; //  u › u    LATIN SMALL LETTER U WITH DIAERESIS AND ACUTE › LATIN SMALL LETTER U
                    case '\u01DA':
                        sb.Append('\u0075');
                        break; //  u › u    LATIN SMALL LETTER U WITH DIAERESIS AND CARON › LATIN SMALL LETTER U
                    case '\u01DC':
                        sb.Append('\u0075');
                        break; //  u › u    LATIN SMALL LETTER U WITH DIAERESIS AND GRAVE › LATIN SMALL LETTER U
                    case '\u0215':
                        sb.Append('\u0075');
                        break; //  ? › u    LATIN SMALL LETTER U WITH DOUBLE GRAVE › LATIN SMALL LETTER U
                    case '\u0217':
                        sb.Append('\u0075');
                        break; //  ? › u    LATIN SMALL LETTER U WITH INVERTED BREVE › LATIN SMALL LETTER U
                    case '\u1E73':
                        sb.Append('\u0075');
                        break; //  ? › u    LATIN SMALL LETTER U WITH DIAERESIS BELOW › LATIN SMALL LETTER U
                    case '\u1E75':
                        sb.Append('\u0075');
                        break; //  ? › u    LATIN SMALL LETTER U WITH TILDE BELOW › LATIN SMALL LETTER U
                    case '\u1E77':
                        sb.Append('\u0075');
                        break; //  ? › u    LATIN SMALL LETTER U WITH CIRCUMFLEX BELOW › LATIN SMALL LETTER U
                    case '\u1E79':
                        sb.Append('\u0075');
                        break; //  ? › u    LATIN SMALL LETTER U WITH TILDE AND ACUTE › LATIN SMALL LETTER U
                    case '\u1E7B':
                        sb.Append('\u0075');
                        break; //  ? › u    LATIN SMALL LETTER U WITH MACRON AND DIAERESIS › LATIN SMALL LETTER U
                    case '\u1EE5':
                        sb.Append('\u0075');
                        break; //  ? › u    LATIN SMALL LETTER U WITH DOT BELOW › LATIN SMALL LETTER U
                    case '\u1EE7':
                        sb.Append('\u0075');
                        break; //  ? › u    LATIN SMALL LETTER U WITH HOOK ABOVE › LATIN SMALL LETTER U
                    case '\u1EE9':
                        sb.Append('\u0075');
                        break; //  ? › u    LATIN SMALL LETTER U WITH HORN AND ACUTE › LATIN SMALL LETTER U
                    case '\u1EEB':
                        sb.Append('\u0075');
                        break; //  ? › u    LATIN SMALL LETTER U WITH HORN AND GRAVE › LATIN SMALL LETTER U
                    case '\u1EED':
                        sb.Append('\u0075');
                        break; //  ? › u    LATIN SMALL LETTER U WITH HORN AND HOOK ABOVE › LATIN SMALL LETTER U
                    case '\u1EEF':
                        sb.Append('\u0075');
                        break; //  ? › u    LATIN SMALL LETTER U WITH HORN AND TILDE › LATIN SMALL LETTER U
                    case '\u1EF1':
                        sb.Append('\u0075');
                        break; //  ? › u    LATIN SMALL LETTER U WITH HORN AND DOT BELOW › LATIN SMALL LETTER U
                    case '\u028B':
                        sb.Append('\u0076');
                        break; //  ? › v    LATIN SMALL LETTER V WITH HOOK › LATIN SMALL LETTER V
                    case '\u1E7D':
                        sb.Append('\u0076');
                        break; //  ? › v    LATIN SMALL LETTER V WITH TILDE › LATIN SMALL LETTER V
                    case '\u1E7F':
                        sb.Append('\u0076');
                        break; //  ? › v    LATIN SMALL LETTER V WITH DOT BELOW › LATIN SMALL LETTER V
                    case '\u0175':
                        sb.Append('\u0077');
                        break; //  w › w    LATIN SMALL LETTER W WITH CIRCUMFLEX › LATIN SMALL LETTER W
                    case '\u1E81':
                        sb.Append('\u0077');
                        break; //  ? › w    LATIN SMALL LETTER W WITH GRAVE › LATIN SMALL LETTER W
                    case '\u1E83':
                        sb.Append('\u0077');
                        break; //  ? › w    LATIN SMALL LETTER W WITH ACUTE › LATIN SMALL LETTER W
                    case '\u1E85':
                        sb.Append('\u0077');
                        break; //  ? › w    LATIN SMALL LETTER W WITH DIAERESIS › LATIN SMALL LETTER W
                    case '\u1E87':
                        sb.Append('\u0077');
                        break; //  ? › w    LATIN SMALL LETTER W WITH DOT ABOVE › LATIN SMALL LETTER W
                    case '\u1E89':
                        sb.Append('\u0077');
                        break; //  ? › w    LATIN SMALL LETTER W WITH DOT BELOW › LATIN SMALL LETTER W
                    case '\u1E98':
                        sb.Append('\u0077');
                        break; //  ? › w    LATIN SMALL LETTER W WITH RING ABOVE › LATIN SMALL LETTER W
                    case '\u1E8B':
                        sb.Append('\u0078');
                        break; //  ? › x    LATIN SMALL LETTER X WITH DOT ABOVE › LATIN SMALL LETTER X
                    case '\u1E8D':
                        sb.Append('\u0078');
                        break; //  ? › x    LATIN SMALL LETTER X WITH DIAERESIS › LATIN SMALL LETTER X
                    case '\u00FD':
                        sb.Append('\u0079');
                        break; //  ý › y    LATIN SMALL LETTER Y WITH ACUTE › LATIN SMALL LETTER Y
                    case '\u00FF':
                        sb.Append('\u0079');
                        break; //  y › y    LATIN SMALL LETTER Y WITH DIAERESIS › LATIN SMALL LETTER Y
                    case '\u0177':
                        sb.Append('\u0079');
                        break; //  y › y    LATIN SMALL LETTER Y WITH CIRCUMFLEX › LATIN SMALL LETTER Y
                    case '\u01B4':
                        sb.Append('\u0079');
                        break; //  ? › y    LATIN SMALL LETTER Y WITH HOOK › LATIN SMALL LETTER Y
                    case '\u0233':
                        sb.Append('\u0079');
                        break; //  ? › y    LATIN SMALL LETTER Y WITH MACRON › LATIN SMALL LETTER Y
                    case '\u1E8F':
                        sb.Append('\u0079');
                        break; //  ? › y    LATIN SMALL LETTER Y WITH DOT ABOVE › LATIN SMALL LETTER Y
                    case '\u1E99':
                        sb.Append('\u0079');
                        break; //  ? › y    LATIN SMALL LETTER Y WITH RING ABOVE › LATIN SMALL LETTER Y
                    case '\u1EF3':
                        sb.Append('\u0079');
                        break; //  ? › y    LATIN SMALL LETTER Y WITH GRAVE › LATIN SMALL LETTER Y
                    case '\u1EF5':
                        sb.Append('\u0079');
                        break; //  ? › y    LATIN SMALL LETTER Y WITH DOT BELOW › LATIN SMALL LETTER Y
                    case '\u1EF7':
                        sb.Append('\u0079');
                        break; //  ? › y    LATIN SMALL LETTER Y WITH HOOK ABOVE › LATIN SMALL LETTER Y
                    case '\u1EF9':
                        sb.Append('\u0079');
                        break; //  ? › y    LATIN SMALL LETTER Y WITH TILDE › LATIN SMALL LETTER Y
                    case '\u017A':
                        sb.Append('\u007A');
                        break; //  ź › z    LATIN SMALL LETTER Z WITH ACUTE › LATIN SMALL LETTER Z
                    case '\u017C':
                        sb.Append('\u007A');
                        break; //  ż › z    LATIN SMALL LETTER Z WITH DOT ABOVE › LATIN SMALL LETTER Z
                    case '\u017E':
                        sb.Append('\u007A');
                        break; //  ž › z    LATIN SMALL LETTER Z WITH CARON › LATIN SMALL LETTER Z
                    case '\u01B6':
                        sb.Append('\u007A');
                        break; //  z › z    LATIN SMALL LETTER Z WITH STROKE › LATIN SMALL LETTER Z
                    case '\u0225':
                        sb.Append('\u007A');
                        break; //  ? › z    LATIN SMALL LETTER Z WITH HOOK › LATIN SMALL LETTER Z
                    case '\u0290':
                        sb.Append('\u007A');
                        break; //  ? › z    LATIN SMALL LETTER Z WITH RETROFLEX HOOK › LATIN SMALL LETTER Z
                    case '\u0291':
                        sb.Append('\u007A');
                        break; //  ? › z    LATIN SMALL LETTER Z WITH CURL › LATIN SMALL LETTER Z
                    case '\u1E91':
                        sb.Append('\u007A');
                        break; //  ? › z    LATIN SMALL LETTER Z WITH CIRCUMFLEX › LATIN SMALL LETTER Z
                    case '\u1E93':
                        sb.Append('\u007A');
                        break; //  ? › z    LATIN SMALL LETTER Z WITH DOT BELOW › LATIN SMALL LETTER Z
                    case '\u1E95':
                        sb.Append('\u007A');
                        break; //  ? › z    LATIN SMALL LETTER Z WITH LINE BELOW › LATIN SMALL LETTER Z
                    default:
                        sb.Append(letter);
                        break;
                }
            }
            return sb.ToString();
        }
    }
}