<?php
class produk{
	public $jenis;
	public $merk;
	public $stok;
	
	public function order($amount){
		$a = $this->stok-$amount;
		if($a<0){
			$this->printover("-");
			return $this->stok;
		}
		return $this->stok-=$amount;
		//return $this->stok=$this->stok-1; 
	}
	
	public function refill($amount){
		$a = $this->stok+$amount;
		if($a>100){
			$this->printover("+");
			return $this->stok;
		}
		return $this->stok+=$amount; 
	}
	
	public function printover($args){
		if($args == "-"){
			echo "Permintaan beli barang ".$this->jenis." ".$this->merk." melebihi stok yang ada ($this->stok unit)<br>";
			return;
		}
		echo "Permintaan tambah barang ".$this->jenis." ".$this->merk." melebihi batas stok(100 unit)<br>";
	}
	
	public function check()
	{
		echo $this->jenis." ".$this->merk." stok nya adalah " .$this->stok."<br>";
	}
	
	public function __construct($a, $b, $c){
		$this->jenis = $a;
		$this->merk = $b;
		$this->stok = $c;
		//echo "Inisialisasi Barang ".$this->jenis." ".$this->merk." dengan stok " .$this->stok."<br>";
		$this->check();
    }
	
}
$produk0 = new produk("tv", "samsul", 10);
$produk1 = new produk("hp", "xiomay", 80);
//echo $produk0->cekProduk();
$produk0->order(10);
$produk0->check();
$produk0->refill(5); 
$produk0->check();
$produk0->order(6); 
$produk0->check();
$produk1->order(15);
$produk1->check();
$produk1->refill(40); 
$produk1->check();
$produk1->refill(20); 
$produk1->check();
?>