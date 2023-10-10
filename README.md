# FUNDAMENTAL C++

### Struktur Umum Program C++

1. Deklarasi Pustaka
menyediakan sekumpulan fungsi, kelas, dan metode yang dapat digunakan dalam program tanpa perlu menulis ulang kode tersebut. Deklarasi namespace menggunakan pernyataan "using" atau "using namespace". Pada contoh, kita menggunakan pustaka System. Pustaka ini kita butuhkan untuk menggunakan class Console dan method WriteLine().
2. Class adalah sebuah rancangan atau blue print / Cetak Biru dari objek. Cukup pahami saja bahwa class itu merupakan nama program.
3. Method / Fungsi adalah sebuah fitur guna  memecah  program menjadi bagian yang lebih kecil dan kompleks agar bisa dipakai lagi. Fungsi yang harus ada pada sebuah program adalah fungsi Main(), karena fungsi Main() merupakan fungsi utama yang akan dieksekusi pertama kali.

### Variable

Variable merupakan tempat untuk menyimpan data.
Variable sangat berguna ketika kita ingin menggunakan data yang sama berkali-kali, daripada kita buat berulang-ulang, lebih baik kita simpan data tersebut dalam variable
Variable wajib memiliki tipe data dan nama variable.
Ketika kita akan mengakses variable, kita cukup menyebutkan  nama variable nya.

Untuk membuat deklarasi variable, kita bisa gunakan format :
``TipeData namaVariable;``
Biasanya penamaan variable di C# menggunakan ``camelCase``, seperti ``firstName, lastName, longVariableName``
Setelah mendeklarasikan variable, kita bisa mengubah isi variable dengan cara :
``namaVariable = isi value``

Variable juga bisa dibuat langsung dengan deklarasi nilai nya.
Cara membuatnya kita bisa gunakan perintah :
``TipeData namaVariable = isivariable;``

Saat kita membuat variable langsung dengan nilainya, kita bisa menggunakan kata kunci var sebagai pengganti TipeData nya
TipeData akan dibaca sesuai dengan isi nilai nya secara otomatis oleh C#, sehingga kita tidak perlu menyebutkan TipeData nya lagi
Cara menggunakan kata kunci var, seperti ini :
``var namaVariable = value;``

Const digunakan untuk menjadikan variable dan nilainya menjadi immutable (tidak bisa diubah sama sekali)
Jangan membuat konstanta untuk mewakili informasi yang Anda perkirakan akan berubah sewaktu-waktu.
Kata kunci const akan menjadikan data di hardcode pada saat C# melakukan kompilasi kode program.
Misal jika kita membuat data waktu saat ini menggunakan const, nilai waktu akan di hardcode ketika kode program di kompilasi, sehingga tidak akan pernah berubah.

### Komentar

Komentar adalah kode program yang akan diabaikan ketika kode program di dijalankan
Biasanya komentar digunakan untuk menambahkan dokumentasi pada kode program

Single-line atau satu baris, bisa menggunakan perintah :
``// silahkan komentar disini``,
Multi-line atau lebih dari satu baris, bisa menggunakan perintah :
``/*
komentar
*/``

### Tipe Data

Number adalah tipe data angka, terdapat beberapa jenis tipe data Number, yakni int, float, dan double.
int merupakan tipe data bilangan bulat,
double dan float merupakan tipe data bilangan desimal,
Penulisan koma dalam double menggunakan titik, bukan koma, jadi jika kita akan membuat bilangan desimal 0,5 (nol koma lima), maka ditulis 0.5. 
Penulisan tipe data float sama dengan double hanya saja di akhir perlu ditambah dengan huruf f, 0.5f.

String merupakan tipe data text.
Untuk membuat String, kita bisa menggunakan tanda kutip satu atau kutip dua, lalu di dalamnya berisi nilai text nya.

Ada beberapa hal yang bisa kita gunakan menggunakan karakter Backslash pada tipe data string.
``"\t"`` bisa kita  gunakan untuk membuat kolom
``"\r"`` bisa kita gunakan untuk membuat baris
Jika kita ingin membuat tanda kutip dua, yang biasanya kita gunakan untuk membuat judul maka kita bisa menggunakan ``\”``

Terkadang kita ada kebutuhan yang mengharuskan kita untuk membuat string menjadi lowercase, uppercase, menghitung panjang string dan menggabungkan string
Dalam c# untuk menjadikan huruf lowercase ada satu fungsi yaitu ``ToLower()``
Untuk menjadikan uppercase`` ToUpper()``
Untuk menghitung karakter pada sebuah string bisa kita gunakan properti length
Dan ada saatnya kita butuh untuk menggabungkan string, yaitu cukup dengan menggunakan karakter tambah (+)

String mendukung expression, dimana di dalam expression kita bisa mengambil data dari variable lain
Untuk mengidentifikasi string yang diinterpolasi, cukup tambahkan simbol ``$``

Tipe data boolean dalam bahasa pemrograman C# digunakan untuk merepresentasikan dua nilai yang mungkin: ``true`` (benar) atau ``false`` (salah).
Ini adalah tipe data yang sangat penting dalam logika pemrograman karena digunakan untuk mengontrol alur eksekusi program dan membuat keputusan berdasarkan kondisi tertentu.
Tipe data boolean juga sering digunakan dalam ekspresi logika seperti ``&&`` (dan), ``||`` (atau), dan ``!`` (negasi) untuk membuat ekspresi yang lebih kompleks untuk pengambilan keputusan dalam program.

Dalam c# terdapat dua jenis tipe dari casting / konversi tipe data yaitu :
1. implisit (otomatis) -> mengonversi dari tipe data yang memiliki size yang lebih kecil ke yang lebih besar

``char -> int -> long -> float -> double``

2. eksplisit (manual)  -> mengonversi dari tipe data yang memiliki size yang lebih besar ke yang lebih kecil
   
``double -> float -> long -> int -> char``

### Array

Array dalam C# digunakan untuk menyimpan koleksi elemen dengan tipe data yang sama dalam urutan terindeks.
Indeks array dimulai dari 0, yang berarti elemen pertama memiliki indeks 0, elemen kedua memiliki indeks 1, dan seterusnya.
Array dapat memiliki dimensi tunggal, 2 dimensi, dan multidimensi yang lain.
Panjang setiap dimensi ditetapkan saat instance array dibuat.
Kita bisa memanggil elemen array berdasar indexnya. yang nantinya bisa menggunakan perulangan (materi selanjutnya).
Cara mendeklarasikan array adalah sebagai berikut
``tipeData[] namaVariable; atau tipeData[] namaVariable = new int[5];``
Untuk memasukkan nilai ke dalamnya, kita dapat menempatkan nilai dalam daftar yang dipisahkan dengan koma, di dalam kurung kurawal, seperti berikut
``tipeData[] namaVariable = {"Volvo", "BMW", "Ford", "Mazda"};``

Terkadang kita butuh menyimpan data kita dalam bentuk tabel yang terdiri dari baris dan kolom.
Meskipun terlihat sedikit rumit, namun terdapat beberapa kondisi saat kita membuat sebuah program yang mengharuskan untuk menggunkan array multidimensi ini.
Untuk mendeklarasikan array multidimensi kita bisa menggunakan cara berikut

``2 Dimensi ,  tipeData[,] namaVariable = new int[3,2]`` atau ``tipeData[,] namaVariable ={ {1,2}, {3,4}, {4,5} }``

``3 Dimensi tipeData[,,] namaVariable = new int[2,2,3]`` atau ``tipeData[,,] namavariable = { { { 1,2,3 },{ 4,5,6 } },{ { 7,8,9 },{ 10,11,12 } } }``

### List

List dalam C# adalah salah satu struktur data yang sangat berguna dan fleksibel yang digunakan untuk menyimpan kumpulan elemen atau objek dalam urutan tertentu.
List ini termasuk dalam namespace ``System.Collections.Generic.``
List memungkinkan Anda untuk menambahkan, menghapus, atau mengakses elemen-elemen di dalamnya dengan mudah.
Ada Beberapa method/ fungsi yang dapat kita gunakan pada ``List, add(),AddRange(),Remove(), RemoveAt(), IndexOf(), Containts(), Count()``
Untuk membuat List kita bisa menentukan tipe datanya, misal  ``List<tipeData> namaVariable = new List<tipeData>;``

Atau bisa mendeklarasikan langsung isinya dengan kata kunci var, ``var namaVariable = new List<tipeData>{“game”, “mobile”, “web”};``

### Pengkondisian

``if-else`` adalah salah satu pengendalian alur program yang digunakan untuk mengambil keputusan berdasarkan kondisi tertentu. Ini memungkinkan program untuk menjalankan blok kode tertentu jika kondisi tertentu terpenuhi, dan menjalankan blok kode lain jika kondisi tersebut tidak terpenuhi.

``if`` Statement: Blok kode dalam if statement akan dijalankan jika kondisi yang diuji adalah benar (``true``).

``else`` Statement: Blok kode dalam else statement akan dijalankan jika kondisi yang diuji dalam if adalah salah (``false``).

``else if`` Statement: Anda dapat menggunakan else if statement untuk menguji beberapa kondisi secara berurutan. Blok kode dalam else if statement akan dijalankan jika kondisi yang diuji dalam if sebelumnya adalah salah (``false``), dan kondisi dalam else if adalah benar (``true``).

``switch`` adalah salah satu struktur kontrol yang digunakan dalam pemrograman untuk membuat keputusan berdasarkan nilai ekspresi yang berbeda.
Ini memungkinkan program untuk menjalankan blok kode tertentu berdasarkan nilai ekspresi yang cocok dengan salah satu dari beberapa kasus yang telah ditentukan.

``case`` adalah nilai-nilai atau ekspresi yang dibandingkan dengan ekspresi ``switch``. Jika salah satu case cocok dengan ekspresi switch, blok kode dalam case tersebut akan dijalankan.
Default (default): case default adalah case yang dijalankan jika tidak ada case yang cocok dengan ekspresi switch. Ini bersifat opsional dan tidak harus ada dalam setiap struktur switch.


### Ternary Operator

Operator ternary adalah cara singkat untuk mengevaluasi ekspresi berdasarkan kondisi tertentu.
Sama seperti if else namun ini versi singkatya.
penulisan ternary operator adalah sebagai berikut

``kondisi ? nilaiJikaBenar : nilaiJikaSalah;``

### Perulangan

Perulangan atau looping adalah konsep yang sangat penting dalam pemrograman yang digunakan untuk mengulangi serangkaian perintah atau tugas tertentu berulang kali selama kondisi tertentu terpenuhi. 
Dengan menggunakan perulangan, Anda dapat mengeksekusi blok kode yang sama berulang kali tanpa harus menulisnya secara berulang.

Ada beberapa jenis perulangan yang umum digunakan dalam C#, ``For,while, do while, foreach``

### Break & Continue

Break (``break``) adalah pernyataan yang biasanya digunakan dalam loop (for, while, atau do-while) atau dalam struktur switch untuk menghentikan eksekusi loop atau keluar dari struktur switch lebih awal. 
Jika terdapat kode program setelah break, maka kode tersebut tidak akan dikerjakan / akan diabaikan. 

Continue (``continue``) adalah pernyataan yang digunakan dalam loop untuk melanjutkan ke iterasi berikutnya tanpa menjalankan kode di bawahnya dalam iterasi saat ini.
Ini berguna ketika Anda ingin mengabaikan beberapa iterasi loop berdasarkan kondisi tertentu.

### Function

Fungsi (juga dikenal sebagai metode dalam konteks C#) adalah blok kode yang digunakan untuk menjalankan tugas tertentu.
Fungsi memungkinkan untuk mengelompokkan sejumlah pernyataan ke dalam satu unit yang dapat digunakan kembali. 
Fungsi memiliki nama dan dapat menerima argumen (data yang diteruskan ke dalamnya) dan mengembalikan nilai (hasil dari operasinya).
