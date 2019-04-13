<?php
if(isset($_POST['Hitung']))
{
	$alas=$_POST['alas'];
	$tinggi=$_POST['tinggi'];
	$tinggi_=$_POST['tinggi_'];
	$luas = (1/2) * $alas * $tinggi;
	echo "Luas = 1/2 * a * t";
	echo nl2br ("\n");
	echo "Luas = 1/2 * $alas * $tinggi = $luas";
	function vol($luas, $tinggi_)
	{
		$vol = (1/3) * $luas * $tinggi_;
		echo nl2br ("\nVolume Limas Segitiga = 1/3 * luas alas * t limas\n");
		echo "Volume = 1/3 * $luas * $tinggi_ = $vol";
	}
	vol($luas, $tinggi_);
}
?>