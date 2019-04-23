<?php
	class bangunruang {
		public function persegi ($angka, $angkaa){
			$hasil = $angka * $angkaa;
			echo "Hasilnya adalah $hasil";
		}
		public function segitiga ($angka, $angkaa){
			$hasil = $angka * $angkaa * 0.5;
			echo "Hasilnya adalah $hasil";
		}
		public function lingkaran ($angka){
			$hasil = 3.14 * $angka * $angka;
			echo "Hasilnya adalah $hasil";
		}
		public function layang ($angka, $angkaa){
			$hasil = $angka * $angkaa * 0.5;
			echo "Hasilnya adalah $hasil";
		}
	}
?>