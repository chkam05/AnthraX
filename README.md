# AnthraX_CSharp

Aplikacja odtwarzająca muzykę, obsługująca pliki takie jak *.mp3, *.ogg, *.wav.
Odtwarzacz wyposażony jest w wizualizacje muzyczne i zaawansowany system personalizacji wyglądu.

<img src="/Images/main.png">

<img src="/Images/play.png">

Dodatkowo, aplikacja posiada funkcje:
- Listy odtwarzania
- Bibliotekę
- Przeglądarkę Plików
- Equalizer i efekty
- Ustawienia

## Wizualizacje

W aplikacji dostępne są proste wizualizacje:
- Domyślna
- Odwrotna
- Środkowa
- Opadająca w środkach
- Okrężna

<img src="/Images/vis_circle.png">

## Biblioteka

Biblioteka pozwala na zarządzanie listą odtwarzania:
- Dodawanie, usuwanie i przesuwanie utworów
- Sortowanie listy po nazwie, tytule, artyście czy albumie
- Zapisywanie listy odtwarzania i jej odczytywanie z biblioteki programu lub pliku

<img src="/Images/library.png">

## Przeglądarka Plików

Przeglądarka plików pozwala na bezpośrednie załadowanie pliku do odtwarzacza z poziomu odtwarzacza.

<img src="/Images/explorer.png">

## Equalizer i efekty

Aplikacja wyposażona jest również w wiele różnych konfiguracji equalizera.
Poza domyślnymi można również w nieskończoność definiować swoje.

<img src="/Images/eqalizer.png">

Istnieją również różne efekty które można łączyć i zmieniać ich konfigurację:
- Amplification (wzmocnienie głosu)
- Soft Saturation (nasycenie dźwięku, w głównej mierze podbicie wysokich tonów)
- Stereo Enhancer (wzmacniacz stereo)
- Infinite impulse response delay filter (zaawansowane tworzenie echa)
- Echo (echo)
- Reverb (wirtualizacja pomieszczenia)
- Chorus (chór)

<img src="/Images/effects.png">

## Ustawienia

General:
Istnieje tutaj tylko jedna opcja która umożliwa uruchomienie animacji wejścia wizualizacji.

<img src="/Images/settings_01.png">

Informations:
Opis programu i przydatne informacje.

<img src="/Images/settings_02.png">

Media Player:
- Czas wyświetlania informacji o odtwarzanym utworze na górze aplikacji (brak, 1-15s, lub nieskończoność)
- Użycie powiadomień systemu po rozpoczęciu odtwarzania kolejnego nagrania
- Automatyczne rozpoczęcie odtwarzania nagrania po załadowaniu go do odtwarzacza
- Automatyczne przejście do początku po zakończeniu odtwarzania listy
- Zapisanie ostatnio odtwarzanej listy i jej załadowanie przy ponownym uruchomieniu programu

<img src="/Images/settings_03.png">

Sound:
W tym miejscu można wybrać urządzenie dźwiękowe na jakim będzie odtwarzana muzyka.

<img src="/Images/settings_04.png">

Theme:
- Theme Type (wybór koloru szaty graficznej odtwarzacza, domyślny czarny, wbudowane, własny, bądź systemowy)
- Theme Background (wybór tła wizualizacji, kolor, wbudowany obraz, własny lub tapeta systemowa co powoduje zlanie się aplikacji z pulpitem systemu Windows)
- Additional Options (użycie czarnych ikon interfejsu, oraz przeźroczystość elementów kontrolnych programu)

<img src="/Images/settings_05.png">

Visualisation:
- Visualisation Type (typ wyświetlanej wizualizacji)
- Logo (wybór kolorystyki logo lub jego brak)
- Visualisation style (wybór koloru wizualizacji, wbudowany, własny, lub spektrum tęczy wraz z jego konfiguracją (szybkość zmiany i zakres))
- FillStyle (wypełnienie bloków wizualizacji (obramowanie albo wypełnienie))

<img src="/Images/settings_06.png">

## Referencje i wymagania

Aby aplikacja mogła się kompilować a tym bardziej działać, są wymagane określone biblioteki:

- [Biblioteka bass.net.dll dla Visual Studio](http://bass.radio42.com/)
- [taglib-sharp.dll](https://github.com/mono/taglib-sharp)
- [Unseen bass.dll](https://www.un4seen.com/)
- [Unseen basswasapi.dll](https://www.un4seen.com/)