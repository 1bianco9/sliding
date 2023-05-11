         Largest Series Product


Data una stringa formata solo da cifre, calcolare il prodotto più grande per una sua sottostringa contigua di cifre di lunghezza N.

Ad esempio:

data in ingresso la stringa "1027839564",

il prodotto più grande per una serie di 3 cifre è 270 (9 * 5 * 6)

e il prodotto più grande per una serie di 5 cifre è 7560 (7 * 8 * 3 * 9 * 5).

Per l'ingresso "73167176531330624919225119674426574742355349194934", il prodotto più grande per una serie di 6 cifre è 23520.

Spiegazione del codice:

![controllisss](https://github.com/1bianco9/sliding/assets/116873906/eba4bcf1-5dfc-4dd8-a81f-c6e33bd8e3b6)

Con questo codice andiamo ad eliminare alcuni problemi; per esempio se il numero da moltiplicare sono maggiori dei numeri di digits(stringa), andiamo a controllare se il numero da moltiplicare è minore di zero e inoltre andiamo a verificare la stringa che non deve essere vuota e che il numero sia diverso da zero. In caso contrario da come valore di ritorno 1 



![digtoarr](https://github.com/1bianco9/sliding/assets/116873906/1ea97bcf-14c9-4072-b2d0-4e71a302ddc7)

Questo codice calcola il prodotto di un intervallo di numeri all'interno di una lista di interi. Il primo ciclo for scorre la lista di interi fino alla posizione in cui è possibile cominciare a formare un intervallo di lunghezza "span" mentre il secondo ciclo calcola il prodotto degli elementi all'interno dell'intervallo, utilizzando la funzione TryParse per convertire ciascun elemento in un numero intero.
Se il prodotto è maggiore del valore massimo memorizzato in prodmassimo allora viene aggiornato.
