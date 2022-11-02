// operation class larinin soyutlanmasi

using Abstraction;

BasvuruManager basvuruManager = new BasvuruManager();

basvuruManager.BasvuruYap(new IhtiyacKredisiManager());
basvuruManager.BasvuruYap(new KonutKredisiManager());
basvuruManager.BasvuruYap(new TasitKredisiManager());

