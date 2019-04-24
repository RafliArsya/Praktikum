<?php
	class bangunruang {
		public function balok ($a, $b, $c){
			if ($a == $b && $b == $c){
				return $hasil = pow($a,3);
			}
			return $hasil = $a * $b * $c;
		}
		public function prisma ($a, $b, $c){
			$luas = (1/2) * $a * $b;
			return $hasil = (1/2) * $luas * $c;
		}
		public function limas ($a, $b, $c){
			$luas = (1/2) * $a * $b;
			return $hasil = (1/3) * $luas * $c;
		}
		public function tabung ($a, $b){
			return $hasil = 3.14 * pow($a, 2)  * $b;
		}
		public function pthis($a){
			echo "Hasilnya adalah ".$a." m<sup>3</sup>";
		}
	}
?>