_**Simple Parkour Game - PAS Game Development**_

Nama : Yuni Wulandari

Kelas : 11 RPl 1 

Absen : 35

**Dokumentasi Parkour Game**


Simple parkour game ini merupakan game dimana player harus melompat untuk mencapai garis finish di depan. Dan setiap platform yang diinjak, maka score pemain akan bertambah.

Fungsi-fungsi Script:

**controller.cs**

Script ini berfungsi sebagai input, movement dan jump. 

Pertama kita deklarasikan terlebih dahulu variable variable seperti game object, speed, jump force, x y input, dll.

Lalu pada void Update, kita get Input Axis X dan Y dari pemain lalu dimultiply dengan speed.

Lalu masih pada void Update, kita akan mengecek jika pemain menekan tombol space dan player sedang berada di tanah (is grounded), maka kita akan melompat dengan sistem add force.

Lalu pada void FixedUpdate, kita akan apply movement dengan menetapkan position kita ke variable move direction yang berisikan vector x y dan z yang dimultiply dengan speed.


**NormalPlatform.cs**

Script ini berfungsi untuk logika platform yang akan diinjak. Fitur pada script ini ialah mengganti warna pada material platform, menambahkan skor pemain, dll.

Pertama, kita add audio source kepada component platform dan juga box collider (is Trigger checked). Lalu kita deklarasikan variable public bertipe AudioSource agar kita bisa set audio kita pada component nantinya. Lalu kita bind event OnTriggerEnter dan OnTriggerExit. Pada OnTriggerEnter, kita akan mengganti warna dari platform menjadi hijau, sedangkan pada OnTriggerExit kita akan menganti warna platform menjadi abu-abu kembali.

Sistem penggantian warna ini berdasarkan pada Renderer. Pertama kita bikin function ChangeColor dengan input Color. Lalu kita bikin variable cubeRenderer dan mengget component. 
lalu kita get material dari cubeRenderer ini dan menetapkan warnanya. 

**RedArea.cs**

Script ini berfungsi sebagai logika area yang berwarna merah (dead zone). 
Pertama, karena kita ingin mengreset level, kita harus include UnityEngine.SceneManagement;
lalu kita bind event to OnCollisionEnter
dan memanggil SceneManager untuk mengload ulang Scene yang sedang active dan mereset score kembali ke 0.

**ScoreUI.cs**

Script ini berfungsi sebagai penetapan score ke text di canvas UI.
Pertama, karena kita akan berhubungan dengan UI, kita harus include UnityEngine.UI; terlebih dahulu.

Lalu kita deklarasikan variable score dan text. Pada void start, kita get component Text dan pada void Update, kita akan menetapkan value ke text di UI.

**TriggerSFX.cs**

Pada script ini kita akan mengplay sound bedasarkan sound yang kita pilih pada component platform nantinya. Untuk dapat memilih sound kita, kita harus mendeklarasikan variable public AudioSrouce. dan jika sesuatu mengtrigger platform (private void OnTriggerEnter), kita akan memplay sound. 
