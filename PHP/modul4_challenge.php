<?php
class produk{
	public $jenis;
	public $merk;
	public $stok;
	
	public function pesanProduk(){
		return $this->stok--;
		//return $this->stok=$this->stok-1; 
	}
	
	public function cekProduk()
	{
		return $this->jenis." ".$this->merk." dipesan..."." Dan stok nya adalah " .$this->stok."<br>";
	}
}
$produk0 = new produk();
$produk0->jenis="tv";
$produk0->merk="Samsul";
$produk0->stok=20;
$produk1 = new produk();
$produk1->jenis="hp";
$produk1->merk="xiomay";
$produk1->stok=15;
echo $produk0->cekProduk();
$produk0->pesanProduk();
echo $produk0->cekProduk();
$produk0->pesanProduk(); 
echo $produk0->cekProduk();
echo $produk1->cekProduk();
$produk1->pesanProduk();
echo $produk1->cekProduk();
$produk1->pesanProduk(); 
echo $produk1->cekProduk();
?>