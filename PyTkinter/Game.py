from tkinter import *
import random
import pygame
from PIL import ImageTk, Image
from tkinter import messagebox

pygame.mixer.init()
sayac = 0
oyun_sayac = 0
konusma_sayac = 0
dogru_sayac = 0
musicdongu = 10
health = 2
oyun_sayisi = 3
frameCnt = 23

# Defler


def story():
    # İlk Veriler
    global story_button
    global story
    giris_button.destroy()
    isim_girin.destroy()
    sorgu_button1.destroy()
    isim_giris.place(x=20000)
    Launcher_Label.config(text="Kapatmayınız burası Launcher")
    # Story Launch
    story = Toplevel(Launcher)
    story.title("Hikaye")
    story.resizable(width=False, height=False)
    story.geometry("800x400")

    story_background = Label(story,
                             fg="white",
                             image=story_resim1,
                             bg="black",
                             font="italic").pack()
    # Button
    story_button = Button(story)
    story_button.config(text="Oku", bg="black", fg="white",
                        width=12, height=0, command=devam)
    story_button.place(x=600, y=300)


def devam():
    # Counter
    global sayac
    sayac += 1
    if sayac == 8:
        sayac = 0
    # Veri
    hikaye_dosya = open("Metin\\Hikaye", "r+", encoding="utf-8")
    hikaye = hikaye_dosya.readlines()
    # Sorgu
    satir = []
    for i in range(-1, len(hikaye)-1):
        x = hikaye[i]
        z = len(x)
        a = x[:z-1]
        satir.append(a)
    satir.append(hikaye[i+1])
    hikaye_yazisi = (satir[sayac])
    hikaye_dosya.close()
    # Yazılan hikaye
    story_label = Label(story)
    story_label.config(text=hikaye_yazisi,
                       fg="white",
                       bg="black",
                       width=85, height=15,
                       font=("minecraft", 10))
    story_label.place(relx=0.5, rely=0.2, anchor=CENTER)
    if sayac == 7:
        story_button.config(text="Başla", bg="black",
                            fg="white", width=12, height=0, command=konusma)


def konusma():
    # İlk veriler
    story.destroy()
    global frameCnt
    global konumsa_label
    global boss_konusma
    global bosskonusma_button
    # Boss konuşma Launch
    boss_konusma = Toplevel(Launcher)
    boss_konusma.title("Konuşma")
    boss_konusma.resizable(width=False, height=False)
    boss_konusma.geometry("800x400")
    # Backgorund

    def update(ind):
        frame = bossgif_image[ind]
        ind += 1
        if ind == frameCnt:
            ind = 0
        konusma_gif.configure(image=frame)
        boss_konusma.after(100, update, ind)
    konusma_gif = Label(boss_konusma)
    konusma_gif.pack()
    boss_konusma.after(0, update, 0)
    # Label
    konumsa_label = Label(boss_konusma,
                          text="Sen kimsin",
                          fg="white",
                          bg="black",
                          width=65, height=5,
                          font=("minecraft", 10))
    konumsa_label.place(relx=0.5, rely=0.8, anchor=CENTER)
    # Button
    bosskonusma_button = Button(boss_konusma)
    bosskonusma_button.config(
        text="Konuş", bg="black", fg="white", width=12, height=0, command=konumsadevam)
    bosskonusma_button.place(relx=0.9, rely=0.9, anchor=CENTER)


def konumsadevam():
    # Konuşma
    global konusma_sayac
    konusma_sayac += 1
    if konusma_sayac == 1:
        konumsa_label.config(text="Seni tanımıyorum.")
        bosskonusma_button.config(text="Devam")
    if konusma_sayac == 2:
        konumsa_label.config(text="Demek Adın " + isim_giris.get())
    if konusma_sayac == 3:
        konumsa_label.config(text="Sen bana uygun bir rakip değilsin.")
    if konusma_sayac == 4:
        konumsa_label.config(text="Şimdi Yıkıl Karşımdan.")
        bosskonusma_button.config(
            text="Çık", bg="black", fg="white", width=12, height=0, command=ilk_kat)
    # Kapılar


def ilk_kat():
    # İlk Veriler
    global birinci_kat
    boss_konusma.destroy()
    dogru_secim.destroy()
    yanlis_secim.destroy()
    birinci_kat = Toplevel(Launcher)
    # Kapı Launch
    birinci_kat.title("Birinci Kat")
    birinci_kat.geometry("800x600")
    birinci_kat.resizable(width=False, height=False)
    # Backgorund
    katbirbackground = Label(birinci_kat,
                             fg="white",
                             image=katbir_resim1,
                             bg="black",
                             font="italic").pack()
    # Label
    birincikat_Label = Label(birinci_kat,
                             text="Hoş geldin savaşçı",
                             font=("Minecraft"),
                             )
    birincikat_Label.place(relx=0.5, rely=0.1, anchor=CENTER)
    # Button

    birincikat_buton1 = Button(birinci_kat)
    birincikat_buton1.config(
        text="kapı1", bg="black", fg="white", image=katbir_kapiresim1, command=sorular)
    birincikat_buton1.place(relx=0.2, rely=0.5, anchor=CENTER)

    birincikat_buton2 = Button(birinci_kat)
    birincikat_buton2.config(
        text="kapı2", bg="black", fg="white", image=katbir_kapiresim1, command=sorular)
    birincikat_buton2.place(relx=0.8, rely=0.5, anchor=CENTER)


def ikinci_kat():
    global ikinci_kat
    sorukapisi.destroy()
    ikinci_kat = Toplevel(Launcher)
    # Kapı Launch
    ikinci_kat.title("İkinci Kat")
    ikinci_kat.geometry("800x600")
    ikinci_kat.resizable(width=False, height=False)
    katbirbackground = Label(ikinci_kat,
                             fg="white",
                             image=katiki_resim1,
                             bg="black",
                             font="italic").pack()
    # Label
    ikinci_kat_Label = Label(ikinci_kat,
                             text="Devam Edecektir...",
                             font=("Minecraft"),
                             )
    ikinci_kat_Label.place(relx=0.5, rely=0.1, anchor=CENTER)


def sorular():
    # İlk Veriler
    global oyun_sayac
    oyun_sayac += 1
    global sorukapisi
    birinci_kat.destroy()
    # Soru kapı Launch
    sorukapisi = Toplevel(Launcher)
    sorukapisi.title("Soru")
    sorukapisi.geometry("800x600")
    sorukapisi.resizable(width=False, height=False)
    # Background
    katbirbackground = Label(sorukapisi,
                             fg="white",
                             image=katbir_resim1,
                             bg="black",
                             font="italic").pack()
    s = open("Metin\\Sorular", "r", encoding="utf-8")
    m = s.readlines()
    l = []
    for i in range(0, len(m) - 1):
        x = m[i]
        z = len(x)
        a = x[:z - 1]
        l.append(a)
    l.append(m[i + 1])
    o = random.choice(l)
    s.close()
    # Soru sorgusu
    if oyun_sayac <= oyun_sayisi:

        if (o == l[0]):

            Label(sorukapisi, text=o, font="minecraft").place(
                relx=0.5, rely=0.1, anchor=CENTER)
            buton1 = Button(sorukapisi)
            buton1.config(text="A) Memory Card", bg="black",
                          fg="white", width=12, height=0, command=yanlis)
            buton1.place(x=200, y=350)

            buton2 = Button(sorukapisi)
            buton2.config(text="B) Hard disk", bg="black",
                          fg="white", width=12, height=0, command=yanlis)
            buton2.place(x=300, y=350)

            buton3 = Button(sorukapisi)
            buton3.config(text="C) Rom", bg="black", fg="white",
                          width=12, height=0, command=yanlis)
            buton3.place(x=400, y=350)

            buton4 = Button(sorukapisi)
            buton4.config(text="D) Ram", bg="black", fg="white",
                          width=12, height=0, command=dogru)
            buton4.place(x=500, y=350)

        elif (o == l[1]):

            Label(sorukapisi, text=o, font="minecraft").place(
                relx=0.5, rely=0.1, anchor=CENTER)
            buton1 = Button(sorukapisi)
            buton1.config(text="A) Klavye", bg="black", fg="white",
                          width=12, height=0, command=yanlis)
            buton1.place(x=200, y=350)

            buton2 = Button(sorukapisi)
            buton2.config(text="B) Ekran", bg="black", fg="white",
                          width=12, height=0, command=yanlis)
            buton2.place(x=300, y=350)

            buton3 = Button(sorukapisi)
            buton3.config(text="C) Mouse", bg="black", fg="white",
                          width=12, height=0, command=yanlis)
            buton3.place(x=400, y=350)

            buton4 = Button(sorukapisi)
            buton4.config(text="D) Daktilo", bg="black",
                          fg="white", width=12, height=0, command=dogru)
            buton4.place(x=500, y=350)

        elif (o == l[2]):

            Label(sorukapisi, text=o, font="minecraft").place(
                relx=0.5, rely=0.1, anchor=CENTER)
            buton1 = Button(sorukapisi)
            buton1.config(text="A) Flash Bellek", bg="black",
                          fg="white", width=12, height=0, command=dogru)
            buton1.place(x=200, y=350)

            buton2 = Button(sorukapisi)
            buton2.config(text="B) ROM Bellek", bg="black",
                          fg="white", width=12, height=0, command=yanlis)
            buton2.place(x=300, y=350)

            buton3 = Button(sorukapisi)
            buton3.config(text="C) Ekran Kartı", bg="black",
                          fg="white", width=12, height=0, command=yanlis)
            buton3.place(x=400, y=350)

            buton4 = Button(sorukapisi)
            buton4.config(text="D) Ekran", bg="black", fg="white",
                          width=12, height=0, command=yanlis)
            buton4.place(x=500, y=350)

        elif (o == l[3]):

            Label(sorukapisi, text=o, font="minecraft").place(
                relx=0.5, rely=0.1, anchor=CENTER)
            buton1 = Button(sorukapisi)
            buton1.config(text="A) İşlemci", bg="black",
                          fg="white", width=12, height=0, command=yanlis)
            buton1.place(x=200, y=350)

            buton2 = Button(sorukapisi)
            buton2.config(text="B) Yüklü programlar", bg="black",
                          fg="white", width=12, height=0, command=yanlis)
            buton2.place(x=300, y=350)

            buton3 = Button(sorukapisi)
            buton3.config(text="C) Mouse", bg="black", fg="white",
                          width=12, height=0, command=dogru)
            buton3.place(x=400, y=350)

            buton4 = Button(sorukapisi)
            buton4.config(text="D) Ram", bg="black", fg="white",
                          width=12, height=0, command=yanlis)
            buton4.place(x=500, y=350)
        elif (o == l[4]):

            Label(sorukapisi, text=o, font="minecraft").place(
                relx=0.5, rely=0.1, anchor=CENTER)
            buton1 = Button(sorukapisi)
            buton1.config(text="A) Klavye", bg="black", fg="white",
                          width=12, height=0, command=yanlis)
            buton1.place(x=200, y=350)

            buton2 = Button(sorukapisi)
            buton2.config(text="B) Mouse", bg="black", fg="white",
                          width=12, height=0, command=yanlis)
            buton2.place(x=300, y=350)

            buton3 = Button(sorukapisi)
            buton3.config(text="C) Barkod Okuyucu", bg="black",
                          fg="white", width=12, height=0, command=yanlis)
            buton3.place(x=400, y=350)

            buton4 = Button(sorukapisi)
            buton4.config(text="D) Hoparlör", bg="black",
                          fg="white", width=12, height=0, command=dogru)
            buton4.place(x=500, y=350)
        elif (o == l[5]):

            Label(sorukapisi, text=o, font="minecraft").place(
                relx=0.5, rely=0.1, anchor=CENTER)
            buton1 = Button(sorukapisi)
            buton1.config(text="A) 3", bg="black", fg="white",
                          width=12, height=0, command=yanlis)
            buton1.place(x=200, y=350)

            buton2 = Button(sorukapisi)
            buton2.config(text="B) 6", bg="black", fg="white",
                          width=12, height=0, command=yanlis)
            buton2.place(x=300, y=350)

            buton3 = Button(sorukapisi)
            buton3.config(text="C) 8", bg="black", fg="white",
                          width=12, height=0, command=dogru)
            buton3.place(x=400, y=350)

            buton4 = Button(sorukapisi)
            buton4.config(text="D) 10", bg="black", fg="white",
                          width=12, height=0, command=yanlis)
            buton4.place(x=500, y=350)

        elif (o == l[6]):

            Label(sorukapisi, text=o, font="minecraft").place(
                relx=0.5, rely=0.1, anchor=CENTER)
            buton1 = Button(sorukapisi)
            buton1.config(text="A) Ram", bg="black", fg="white",
                          width=12, height=0, command=yanlis)
            buton1.place(x=200, y=350)

            buton2 = Button(sorukapisi)
            buton2.config(text="B) Modem", bg="black", fg="white",
                          width=12, height=0, command=yanlis)
            buton2.place(x=300, y=350)

            buton3 = Button(sorukapisi)
            buton3.config(text="C) HDD", bg="black", fg="white",
                          width=12, height=0, command=dogru)
            buton3.place(x=400, y=350)

            buton4 = Button(sorukapisi)
            buton4.config(text="D) Rom", bg="black", fg="white",
                          width=12, height=0, command=yanlis)
            buton4.place(x=500, y=350)

        elif (o == l[7]):

            Label(sorukapisi, text=o, font="minecraft").place(
                relx=0.5, rely=0.1, anchor=CENTER)
            buton1 = Button(sorukapisi)
            buton1.config(text="A) İşlem hacmi", bg="black",
                          fg="white", width=12, height=0, command=dogru)
            buton1.place(x=200, y=350)

            buton2 = Button(sorukapisi)
            buton2.config(text="B) Yorum yeteneği", bg="black",
                          fg="white", width=12, height=0, command=yanlis)
            buton2.place(x=300, y=350)

            buton3 = Button(sorukapisi)
            buton3.config(text="C) Düşünme gücü", bg="black",
                          fg="white", width=12, height=0, command=yanlis)
            buton3.place(x=400, y=350)

            buton4 = Button(sorukapisi)
            buton4.config(text="D) Mantık yürütme", bg="black",
                          fg="white", width=12, height=0, command=yanlis)
            buton4.place(x=500, y=350)

        elif (o == l[8]):

            Label(sorukapisi, text=o, font="minecraft").place(
                relx=0.5, rely=0.1, anchor=CENTER)
            buton1 = Button(sorukapisi)
            buton1.config(text="A) Alt Gr", bg="black", fg="white",
                          width=12, height=0, command=yanlis)
            buton1.place(x=200, y=350)

            buton2 = Button(sorukapisi)
            buton2.config(text="B) Ctrl+Alt ", bg="black",
                          fg="white", width=12, height=0, command=dogru)
            buton2.place(x=300, y=350)

            buton3 = Button(sorukapisi)
            buton3.config(text="C) Ctrl", bg="black", fg="white",
                          width=12, height=0, command=yanlis)
            buton3.place(x=400, y=350)

            buton4 = Button(sorukapisi)
            buton4.config(text="D) Shift", bg="black", fg="white",
                          width=12, height=0, command=yanlis)
            buton4.place(x=500, y=350)

        elif (o == l[9]):

            Label(sorukapisi, text=o, font="minecraft").place(
                relx=0.5, rely=0.1, anchor=CENTER)
            buton1 = Button(sorukapisi)
            buton1.config(text="A) Character", bg="black",
                          fg="white", width=12, height=0, command=yanlis)
            buton1.place(x=200, y=350)

            buton2 = Button(sorukapisi)
            buton2.config(text="B) Column", bg="black", fg="white",
                          width=12, height=0, command=yanlis)
            buton2.place(x=300, y=350)

            buton3 = Button(sorukapisi)
            buton3.config(text="C) Pixel", bg="black", fg="white",
                          width=12, height=0, command=dogru)
            buton3.place(x=400, y=350)

            buton4 = Button(sorukapisi)
            buton4.config(text="D) Line", bg="black", fg="white",
                          width=12, height=0, command=yanlis)
            buton4.place(x=500, y=350)
    else:
        Label(sorukapisi, text="Bitti Sanıyorsan Yanılıyorsun" + ("\n") + isim_giris.get(),
              font="minecraft").place(relx=0.5, rely=0.1, anchor=CENTER)

        son_kapi = Button(sorukapisi)
        son_kapi.config(text="Diğer Kat", bg="black",
                        fg="white", command=ikinci_kat)
        son_kapi.place(relx=0.5, rely=0.9, anchor=CENTER)


def dogru():
    # İlk Veriler
    global dogru_sayac
    dogru_sayac += 1
    global dogru_secim
    sorukapisi.destroy()
    # Dogru Launch
    dogru_secim = Toplevel(Launcher)
    dogru_secim.geometry("400x250")
    dogru_secim.title("Doğru Bildin")
    dogru_secim.resizable(width=False, height=False)
    # Background
    Background = Label(dogru_secim,
                       image=dogru_bilgiresim,
                       justify=CENTER,
                       height=500,
                       fg="blue")
    Background.pack()
    dogru_label = Label(dogru_secim,
                        font=("Minecraft"),
                        )
    Kapı_button = Button(dogru_secim)
    # Dogru yazı sorgusu
    if dogru_sayac == 1:
        dogru_label.config(text="Bu kolaydı" + ("\n") + isim_giris.get())
    if dogru_sayac == 2:
        dogru_label.config(text="Nasıl bildin bunu seni sefil")
    if dogru_sayac == 3:
        dogru_label.config(
            text="Tahmin ettiğimden iyi bir savaşçısın" + ("\n") + isim_giris.get())
    dogru_label.place(relx=0.5, rely=0.2, anchor=CENTER)
    Kapı_button.config(text="Devam Et", bg="black",
                       fg="white", command=ilk_kat)
    Kapı_button.place(relx=0.5, rely=0.9, anchor=CENTER)


def yanlis():
    play()
    # İlk Veriler
    global yanlis_secim
    global health
    health -= 1
    sorukapisi.destroy()
    # Dogru Launch
    yanlis_secim = Toplevel(Launcher)
    yanlis_secim.geometry("400x250")
    yanlis_secim.title("Yanlış Bilgi")
    yanlis_secim.resizable(width=False, height=False)
    # Background
    Background = Label(yanlis_secim,
                       image=yanlis_bilgiresim,
                       justify=CENTER,
                       height=500,
                       fg="blue")
    Background.pack()
    Kapı_button = Button(yanlis_secim)
    # Yanliş yazı sorgusu
    Kapı_button.config(text="Devam Et", bg="black",
                       fg="white", command=ilk_kat)
    Kapı_button.place(relx=0.5, rely=0.9, anchor=CENTER)


def kapilar():
    # Kapı Bilgisi
    hikaye_dosya = open("Metin\\Kapilar", "r+", encoding="utf-8")
    hikaye = hikaye_dosya.read()
    hikaye_dosya.close()
    messagebox.showinfo(title="Kapılar Hakkında Bilgiler", message=hikaye)


def sorgu():

    # İsim giriş Sorgusu
    global sorgu_button1
    if (isim_giris.get() == ""):
        isim_girin.config(
            text="Boş bırakmayın",
            fg="white",
            bg="black",
            font=("minecraft", 12))
        sorgu_button1 = Button(Launcher)
        sorgu_button1.config(text="Boş girme", bg="black",
                             fg="white", width=12, command=sorgu)
        sorgu_button1.place(relx=0.5, rely=0.8, anchor=CENTER)
        messagebox.showinfo("Boş", "Lütfen İsim girin")

        if messagebox != "":
            sorgu_button1.config(text="Başla", bg="black",
                                 fg="white", width=12, command=sorgu)
            sorgu_button1.destroy()

    else:
        sorgu_button1.destroy()
        story()


def play():
    pygame.mixer.music.load("music\\basari.mp3")
    pygame.mixer.music.play(loops=musicdongu)


# Launcher
Launcher = Tk()
Launcher.geometry("300x200")
Launcher.title("Launcher")
Launcher.resizable(width=False, height=False)


# İmage
launcher_image1 = ImageTk.PhotoImage(Image.open('texture\\launcher.jpg'))

story_resim1 = ImageTk.PhotoImage(Image.open('texture\\doga.jpg'))

katbir_resim1 = ImageTk.PhotoImage(Image.open('texture\\magara.jpg'))

katbir_kapiresim1 = ImageTk.PhotoImage(Image.open('texture\\kapi1.png'))

dogru_bilgiresim = ImageTk.PhotoImage(Image.open('texture\\dogrubilgi.jpg'))

yanlis_bilgiresim = ImageTk.PhotoImage(Image.open('texture\\yanlisbilgi.png'))

katiki_resim1 = ImageTk.PhotoImage(Image.open('texture\\agac.png'))

bossgif_image = [PhotoImage(
    file='texture\\boss.gif', format='gif -index %i' % (i)) for i in range(frameCnt)]


Background = Label(Launcher,
                   image=launcher_image1,
                   justify=CENTER,
                   height=500,
                   fg="blue")
Background.pack()
# Label
Launcher_Label = Label(Launcher,
                       text="Hoş geldin savaşçı",
                       font=("Minecraft"),
                       )
Launcher_Label.place(relx=0.5, rely=0.1, anchor=CENTER)

isim_girin = Label(Launcher,
                   text="İsim Giriniz",
                   fg="white",
                   bg="black",
                   font=("minecraft", 12))
isim_girin.place(relx=0.5, rely=0.3, anchor=CENTER)

isim_giris = Entry(Launcher)
isim_giris.config()
isim_giris.place(relx=0.5, rely=0.5, anchor=CENTER)

# Button
giris_button = Button(Launcher)
giris_button.config(text="Başla", bg="black", fg="white", command=sorgu)
giris_button.place(relx=0.5, rely=0.8, anchor=CENTER)

Kapı_button = Button(Launcher)
Kapı_button.config(text="Kapı Bilgisi", bg="black",
                   fg="white", command=kapilar)
Kapı_button.place(relx=0.2, rely=0.8, anchor=CENTER)
sorgu_button1 = Label()
dogru_secim = Label()
yanlis_secim = Label()
mainloop()
