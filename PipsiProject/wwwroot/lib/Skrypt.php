<?PHP
   $adresat = 'lkuczma@gmail.pl';    // pod ten adres zostanie wysłana wiadomosc
@$email = $_POST['email'];
@$content = $_POST['content'];
   $header =    "From: ktos@serwer.pl \nContent-Type:".
         ' text/plain;charset="iso-8859-2"'.
         "\nContent-Transfer-Encoding: 8bit";
   if (mail($adresat, 'List ze strony', $content, $header))
      echo "<script>alert('Wysłano !'); document.location.href='Contact';</script>";
   else
      echo '<p><b>NIE</b> wysłano maila!</p>';
?>