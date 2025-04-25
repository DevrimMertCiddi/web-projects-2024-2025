function siparisHesap(){
    var corba = document.forms["yemekForm"]["corba"].value;
    //checkbox'lar birbirinden bağımsız çalıştığı için
    //if'ler ile kontrol edilir ve ifler ayrı ayrı olmalıdır

    var nPilav=0;
    if(document.forms["yemekForm"]["nPilav"].checked == true){
        nPilav=document.forms["yemekForm"]["nPilav"].value;
    }

    var pKebap=0;
    if(document.forms["yemekForm"]["pKebap"].checked == true){
        pKebap=document.forms["yemekForm"]["pKebap"].value;
    }

    var manti=0;
    if(document.forms["yemekForm"]["manti"].checked == true){
        manti=document.forms["yemekForm"]["manti"].value;
    }

    var oKebapi=0;
    if(document.forms["yemekForm"]["oKebapi"].checked == true){
        oKebapi=document.forms["yemekForm"]["oKebapi"].value;
    }

    var tatli=document.forms["yemekForm"]["tatli"].value;

    var su=0;
    if(document.forms["yemekForm"]["su"].checked == true){
        su=document.forms["yemekForm"]["su"].value;
    }

    var cay=0;
    if(document.forms["yemekForm"]["cay"].checked == true){
        cay=document.forms["yemekForm"]["cay"].value;
    }

    var ayran=0;
    if(document.forms["yemekForm"]["ayran"].checked == true){
        ayran=document.forms["yemekForm"]["ayran"].value;
    }
    
    var kola=0;
    if(document.forms["yemekForm"]["kola"].checked == true){
        kola=document.forms["yemekForm"]["kola"].value;
    }

    var genelToplam = Number(corba)+Number(su)+Number(kola)+Number(ayran)+Number(cay)+Number(tatli)+Number(oKebapi)+Number(manti)+Number(pKebap)+Number(nPilav);

    document.getElementById('sonuc').innerHTML="Sonuc" + genelToplam + "₺";
    document.getElementById('sonuc').className("alert alert-success fw-bold");

}