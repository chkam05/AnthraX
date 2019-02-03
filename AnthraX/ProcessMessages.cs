using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace AnthraX {

    // ################################################################################
    //  xxxx    xxxx     xxx     xxx    xxxxx    xxxx    xxxx
    //  x   x   x   x   x   x   x   x   x       x       x    
    //  xxxx    xxxx    x   x   x       xxxx     xxx     xxx 
    //  x       x   x   x   x   x   x   x           x       x
    //  x       x   x    xxx     xxx    xxxxx   xxxx    xxxx 
    //
    //  x   x   xxxxx    xxxx    xxxx    xxx     xxxx   xxxxx    xxxx
    //  xx xx   x       x       x       x   x   x       x       x    
    //  x x x   xxxx     xxx     xxx    xxxxx   x  xx   xxxx     xxx 
    //  x   x   x           x       x   x   x   x   x   x           x
    //  x   x   xxxxx   xxxx    xxxx    x   x    xxxx   xxxxx   xxxx 
    // ################################################################################
    internal static class ProcessMessages {

        // ######################################################################
        //  xxxxx   x   x   xxxx     xxx    xxxx    xxxxx
        //    x     xx xx   x   x   x   x   x   x     x  
        //    x     x x x   xxxx    x   x   xxxx      x  
        //    x     x   x   x       x   x   x   x     x  
        //  xxxxx   x   x   x        xxx    x   x     x  
        // ######################################################################

        /// <summary> Pobiera uchwyt do okna najwyższego poziomu, którego nazwa klasy i nazwa okna są zgodne z określonymi ciągami.
        /// Funkcja nie wyszukuje okien potomnych i nie uwzględnia wielkości liter. </summary>
        /// <param name="lpClassName"> Jeśli lpClassName ma wartość null, znajduje dowolne okno, którego tytuł jest zgodny z parametrem lpWindowName. </param>
        /// <param name="lpWindowName"> Nazwa okna (tytuł okna). Jeśli ten parametr ma wartość null, wszystkie nazwy okien są zgodne. </param>
        /// <returns> Jeśli funkcja się powiedzie, zwróconą wartością jest uchwyt okna, które ma określoną nazwę klasy i nazwę okna. </returns>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow( string lpClassName, string lpWindowName );

        // ----------------------------------------------------------------------
        /// <summary> Wysyła określoną wiadomość do okna lub okien. </summary>
        /// <param name="hWnd"> Uchwyt do okna, którego procedura okna otrzyma komunikat. Jeśli tym parametrem jest HWND_BROADCAST((HWND) 0xffff), wiadomość jest wysyłana do wszystkich okien najwyższego poziomu w systemie. </param>
        /// <param name="Msg"> Wiadomość do wysłania. </param>
        /// <param name="wParam"> Dodatkowe informacje dotyczące wiadomości. </param>
        /// <param name="lParam"> Dodatkowe informacje dotyczące wiadomości. </param>
        /// <returns> Zwracana wartość określa wynik przetwarzania komunikatu; zależy to od wysłanej wiadomości. </returns>
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage( IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam );

        /// <summary> Modyfikuje filtr komunikatu UIU(User Interface Privilege Isolation) dla określonego okna</summary>
        /// <param name="hWnd"> Uchwyt do okna, którego filtr komunikatów UIPI ma zostać zmodyfikowany. </param>
        /// <param name="msg"> Komunikat, który umożliwia filtr wiadomości przez lub blokuje. </param>
        /// <param name="action"> Akcja, która ma zostać wykonana, może przyjmować jedną z następujących wartości <see cref = "MessageFilterInfo" /> </param>
        /// <param name="changeInfo"> Opcjonalny wskaźnik do struktury<see cref = "CHANGEFILTERSTRUCT" /> </param>
        /// <returns> Jeśli funkcja się powiedzie, zwraca TRUE; w przeciwnym razie zwraca FALSE. Aby uzyskać rozszerzone informacje o błędach, wywołaj GetLastError. </returns>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool ChangeWindowMessageFilterEx(IntPtr hWnd, uint msg,
            ChangeWindowMessageFilterExAction action, ref CHANGEFILTERSTRUCT changeInfo);

        // ######################################################################
        //   xxxx   xxxxx   xxxx    x   x   x   x   xxxxx   x   x   xxxx    x   x
        //  x         x     x   x   x   x   x  x      x     x   x   x   x   x   x
        //   xxx      x     xxxx    x   x   xxx       x     x   x   xxxx     xxx 
        //      x     x     x   x   x   x   x  x      x     x   x   x   x     x  
        //  xxxx      x     x   x    xxx    x   x     x      xxx    x   x     x  
        //
        //  xxxx     xxx    x   x   x   x    xxx    x   x
        //   x  x   x   x   xx  x   x   x   x   x   x   x
        //   x  x   xxxxx   x x x    xxx    x       xxxxx
        //   x  x   x   x   x  xx     x     x   x   x   x
        //  xxxx    x   x   x   x     x      xxx    x   x
        // ######################################################################
        /// <summary> Uchwyt używany do wysyłania wiadomości do wszystkich okien </summary>
        public static IntPtr HWND_BROADCAST = new IntPtr(0xffff);

        // ----------------------------------------------------------------------
        /// <summary> Aplikacja wysyła wiadomość WM_COPYDATA, aby przekazać dane do innej aplikacji. </summary>
        public static uint WM_COPYDATA = 0x004A;

        // ----------------------------------------------------------------------
        /// <summary> Kontener na dane, które mają być przekazane do innej aplikacji przez wiadomość WM_COPYDATA. </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct COPYDATASTRUCT {
            /// <summary> Dane zdefiniowane przez użytkownika, które należy przekazać do aplikacji odbierającej. </summary>
            public IntPtr dwData;
            /// <summary> Rozmiar, w bajtach, danych wskazywanych przez element lpData. </summary>
            public int cbData;
            /// <summary> Dane, które należy przekazać do aplikacji odbierającej. Ten członek może być IntPtr.Zero. </summary>
            public IntPtr lpData;
        }

        // ----------------------------------------------------------------------
        /// <summary> Wartości używane w strukturze CHANGEFILTERSTRUCT </summary>
        public enum MessageFilterInfo : uint {
            /// <summary> Niektóre komunikaty, których wartość jest mniejsza niż WM_USER, są wymagane do przejścia przez filtr, niezależnie od ustawienia filtra. Nie będzie żadnego efektu, gdy spróbujesz użyć tej funkcji, aby zezwolić na takie wiadomości lub je zablokować. </summary>
            None = 0,
            /// <summary> Wiadomość została już dozwolona przez filtr wiadomości tego okna, więc funkcja zakończyła się powodzeniem bez żadnych zmian w filtrze wiadomości okna. Dotyczy programu MSGFLT_ALLOW. </summary>
            AlreadyAllowed = 1,
            /// <summary> Wiadomość została już zablokowana przez filtr wiadomości tego okna, więc funkcja zakończyła się powodzeniem bez żadnej zmiany w filtrze wiadomości okna. Dotyczy programu MSGFLT_DISALLOW. </summary>
            AlreadyDisAllowed = 2,
            /// <summary> Wiadomość jest dozwolona w zakresie wyższym niż okno. Dotyczy programu MSGFLT_DISALLOW. </summary>
            AllowedHigher = 3
        }

        // ----------------------------------------------------------------------
        /// <summary> Wartości używane przez ChangeWindowMessageFilterEx </summary>
        public enum ChangeWindowMessageFilterExAction : uint {
            /// <summary> Resetuje filtr wiadomości okna dla hWnd do wartości domyślnej. Każda wiadomość dozwolona globalnie lub w całym procesie zostanie przechwycona, ale każdy komunikat nieuwzględniony w tych dwóch kategoriach i który pochodzi z procesu o niższych uprzywilejowanych uprawnieniach, zostanie zablokowany. </summary>
            Reset = 0,
            /// <summary> Umożliwia wysłanie wiadomości przez filtr. Dzięki temu wiadomość może zostać odebrana przez hWnd, niezależnie od źródła wiadomości, nawet jeśli pochodzi z procesu o niższych uprawnieniach. </summary>
            Allow = 1,
            /// <summary> Blokuje wiadomość, która ma zostać dostarczona do hWnd, jeśli pochodzi z procesu o niższych uprawnieniach, chyba że komunikat jest dozwolony w całym procesie przy użyciu funkcji ChangeWindowMessageFilter lub globalnie. </summary>
            DisAllow = 2
        }

        // ----------------------------------------------------------------------
        // <summary> Zawiera rozszerzone informacje o wynikach uzyskane przez wywołanie funkcji ChangeWindowMessageFilterEx. </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct CHANGEFILTERSTRUCT {
            /// <summary> Wielkość struktury w bajtach. Musi być ustawiony na sizeof (CHANGEFILTERSTRUCT), w przeciwnym razie funkcja zawodzi z ERROR_INVALID_PARAMETER. </summary>
            public uint size;
            /// <summary> Jeśli funkcja się powiedzie, to pole zawiera jedną z następujących wartości, <see cref = "MessageFilterInfo" /> </summary>
            public MessageFilterInfo info;
        }

        // ######################################################################
    }

    // ################################################################################
}
