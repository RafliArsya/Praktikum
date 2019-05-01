<?php
	$myarray = array(array("NAMA : ", "Yusuf Rafli B"), array("NAMA : ", "Darul"), array("Kelompok : ", "51"), array("Shift : ", "4"));
	for($i=0;$i<4;$i++){
		for($j=0;$j<2;$j++){
			echo $myarray[$i][$j];
		}
		echo "<br>";
	}
?>
<form method="post">
<select name="bangun" onchange="this.form.submit();">
	<option disabled="disabled" selected="selected">Jenis Bangun Ruang</option>
	<option value="balok">Balok</option>
	<option value="prism">Prisma Segitiga</option>
	<option value="limas">Limas</option>
	<option value="tabung">Tabung</option>
</select>
</form>
<?php
if(isset($_POST['bangun'])){
	switch($_POST['bangun']){
		case "balok":
			header ('Location:balok.php');
			break;
		case "prism":
			header ('Location:prism.php');
			break;
		case "limas":
			header ('Location:limas.php');
			break;
		case "tabung":
			header ('Location:tabung.php');
			break;
		default:
			echo "ERROR 404 Value ".$_POST['bangun']." Not Found!";
			break;
	}
}
?>
