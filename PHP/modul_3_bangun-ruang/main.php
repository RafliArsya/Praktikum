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