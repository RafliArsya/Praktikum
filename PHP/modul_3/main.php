<form method="post">
<select name="bangun" onchange="this.form.submit();">
	<option disabled="disabled" selected="selected">Jenis Bangun Datar</option>
	<option value="persegi">Persegi</option>
	<option value="segitiga">Segitiga</option>
	<option value="lingkaran">Lingkaran</option>
	<option value="layang">Layang-layang</option>
</select>
</form>
<?php
if(isset($_POST['bangun'])){
	switch($_POST['bangun']){
		case "persegi":
			header ('Location:persegi.php');
			break;
		case "segitiga":
			header ('Location:segitiga.php');
			break;
		case "lingkaran":
			header ('Location:lingkaran.php');
			break;
		case "layang":
			header ('Location:layang.php');
			break;
		default:
			echo "ERROR 404 Value ".$_POST['bangun']." Not Found!";
			break;
	}
}
?>