# IO_Lab2
TCP Serwer - Asynchronicznie
Wymagania funkcjonalne:
    1. Administrator uruchamia aplikację serwera.
    2. Serwer rozpoczyna działanie od razu po uruchomieniu aplikacji.
    3. Administrator kończy działanie aplikacji serwera.
    4. Klient łączy się z aplikacją serwera.
    5. Serwer wysyła wiadomość z poleceniem podania numeru miesiąca do wypisania jego nazwy dla klienta.
    6. Klient wysyła swoją liczbę jako odpowiedź do serwera.
    7. Serwer odsyła wiadomość z nazwą miesiąca odpowiadającą na liczbę podaną przez klienta.
    8. Cały proces, czyli wiadomość z poleceniem od serwera, odpowiedzą od klienta i nazwą miesiąca od serwera może się powtarzać w nieskończoność. 

Wymagania pozafunkcjonalne:
    1. Aplikacja serwera jest dostarczona w postaci aplikacji konsolowej przeznaczonej na system Windows.
    2. W komunikacji klient-serwer wykorzystywany jest protokół komunikacji Raw – wiadomości przesyłane są bezpośrednio.
    3. W ramach serwera nie jest implementowana obsługa rozłączającego się klienta.
    4. W ramach serwera nie jest implementowana informacja o wyłączeniu serwera przesłana do klienta.
    5. Serwer może utrzymywać wiele połączeń z różnymi klientami naraz.
    6. W momencie kiedy jeden klient się rozłączy to serwer dalej działa.
