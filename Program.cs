namespace Struct_Kavramı;

class Program
{
    static void Main(string[] args)
    {
        Dikdörtgen dikdörtgen = new Dikdörtgen();
        dikdörtgen.kisakenar = 3;
        dikdörtgen.uzunkenar = 4;
        Console.WriteLine("Class Alan Hesabı      :{0}", dikdörtgen.Alanhesapla());
        Dikdörtgen_struct dikdörtgen_Struct;/*Classtaki gibi new ile oluşturmaya gerek duyulmuyor
        bunun yerine //Dikdörtgen_struct dikdörtgen_Struct; olabilir.//*/
        dikdörtgen_Struct.kisakenar = 5;
        dikdörtgen_Struct.uzunkenar = 6;
        Console.WriteLine("Struct Alan Hesabı:    :{0}", dikdörtgen_Struct.Alanhesapla());
        /* Structlarda kurucu metot yardımı ile alan hesaplama işleminde kullanıcak olan sayıları yukarıdaki
        örnekteki gibi tek tek yazmak yerine direkt olarak Dikdörtgen_struct dikdörtgen_Struct = new Diktörtgen_Struct(3,4) olarak atayabilirim*/
       
       

        

    }
}


class Dikdörtgen
{

  public int kisakenar;
  
  public int uzunkenar;


  public long Alanhesapla()
  {
   
    return this.kisakenar * this.uzunkenar;

  }


}


struct Dikdörtgen_struct
{
  
  public int kisakenar;
  
  public int uzunkenar;

  public Dikdörtgen(int kisaKenar, int uzunKenar)
  {
  kisakenar = kisaKenar;
  uzunkenar = uzunKenar;
  }

  /*Structlarda kurucu metot şu şekilde olur 
  Public Dikdörtgen(int kisakenar, int uzunKenar)
  {
  KisaKenar = kisakenar;
  UzunKenar = uzun kenar; şeklinde olmalı buna(kurucu metota) izin veriyor.
  }       */
  

  public long Alanhesapla()
  {
   
    return this.kisakenar * this.uzunkenar;

  }



}
