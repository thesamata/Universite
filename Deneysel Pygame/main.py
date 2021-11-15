from typing import Counter
import pygame
import json
from pygame import event
from pygame.locals import *

pygame.init()
# Oyun Ekranı
bottomPanel = 150
screenWidth = 800
screenHeight = 400 + bottomPanel

screen = pygame.display.set_mode((screenWidth, screenHeight))
font = pygame.font.SysFont('Minecraft', 30)
pygame.display.set_caption('İlde Game')
# Oluşturulan Renkler

goldColor = (255, 215, 0)
black = (0, 0, 0)
white = (255, 255, 255)
red = (255, 0, 0)
green = (0, 255, 0)

C_Dictionary = json.load(open("character\player_data.txt"))
Gold = C_Dictionary["Gold"]
Food = C_Dictionary["Food"]

# Arka plan resimleri
bgImage = pygame.image.load('img/Background/background.png').convert_alpha()
startImage = pygame.image.load('img/Background/start.jpg').convert_alpha()
panelImage = pygame.image.load('img/Icons/panel.png').convert_alpha()
# KALP RESMİ
hearth_img = pygame.image.load('img/Icons/hearth.png').convert_alpha()
meatImage = pygame.image.load('img/Icons/Meat.png').convert_alpha()
# Ses Efektlerinin tanımı
PetEatSong = pygame.mixer.Sound('sound/petEat.mp3')
PetLoveSong = pygame.mixer.Sound('sound/petLove.mp3')
PetSleepSong = pygame.mixer.Sound('sound/petSleep.mp3')
gameLoopSong = pygame.mixer.Sound('sound/gameLoop.mp3')


clicked = False
# BUTTONLARIN OLUŞTURULMASI


class button():
    button_col = (183, 73, 73)
    hover_col = (225, 30, 56)
    click_col = (255, 0, 0)
    text_col = black
    width = 150
    height = 70

    def __init__(self, x, y, text):
        self.x = x
        self.y = y
        self.text = text

    def draw_button(self):
        global clicked
        action = False
        pos = pygame.mouse.get_pos()
        button_rect = Rect(self.x, self.y, self.width, self.height)

        if button_rect.collidepoint(pos):
            if pygame.mouse.get_pressed()[0] == 1:
                clicked = True
                pygame.draw.rect(screen, self.click_col, button_rect)
            elif pygame.mouse.get_pressed()[0] == 0 and clicked == True:
                clicked = False
                action = True
            else:
                pygame.draw.rect(screen, self.hover_col, button_rect)
        else:
            pygame.draw.rect(screen, self.button_col, button_rect)

        pygame.draw.line(screen, white, (self.x, self.y),
                         (self.x + self.width, self.y), 2)
        pygame.draw.line(screen, white, (self.x, self.y),
                         (self.x, self.y + self.height), 2)
        pygame.draw.line(screen, black, (self.x, self.y + self.height),
                         (self.x + self.width, self.y + self.height), 2)
        pygame.draw.line(screen, black, (self.x + self.width, self.y),
                         (self.x + self.width, self.y + self.height), 2)

        text_img = font.render(self.text, True, self.text_col)
        text_len = text_img.get_width()
        screen.blit(text_img, (self.x + int(self.width / 2) -
                    int(text_len / 2), self.y + 25))
        return action
# PETİN CLASSI


class gamePet:
    def __init__(self, x, y, name, max_hp, max_love, max_hungry, max_sleep):
        self.name = name
        self.max_hp = max_hp
        self.hp = max_hp
        self.max_love = max_love
        self.love = max_love
        self.max_hungry = max_hungry
        self.hungry = max_hungry
        self.max_sleep = max_sleep
        self.sleep = max_sleep
        self.alive = True
        self.animation_list = []
        self.frame_index = 0
        self.action = 0  # 0:idle, 1:love, 2:eat, 3:sleep
        self.update_time = pygame.time.get_ticks()
        temp_list = []
        for i in range(8):
            img = pygame.image.load(f'img/{self.name}/Idle/{i}.png')
            img = pygame.transform.scale(
                img, (img.get_width() * 3, img.get_height() * 3))
            temp_list.append(img)
        self.animation_list.append(temp_list)
        temp_list = []
        for i in range(8):
            img = pygame.image.load(f'img/{self.name}/Love/{i}.png')
            img = pygame.transform.scale(
                img, (img.get_width() * 3, img.get_height() * 3))
            temp_list.append(img)
        self.animation_list.append(temp_list)
        temp_list = []
        for i in range(8):
            img = pygame.image.load(f'img/{self.name}/Eat/{i}.png')
            img = pygame.transform.scale(
                img, (img.get_width() * 3, img.get_height() * 3))
            temp_list.append(img)
        self.animation_list.append(temp_list)
        temp_list = []
        for i in range(8):
            img = pygame.image.load(f'img/{self.name}/Sleep/{i}.png')
            img = pygame.transform.scale(
                img, (img.get_width() * 3, img.get_height() * 3))
            temp_list.append(img)
        self.animation_list.append(temp_list)
        self.image = self.animation_list[self.action][self.frame_index]
        self.rect = self.image.get_rect()
        self.rect.center = (x, y)

    def update(self):

        animation_cooldown = 300
        self.image = self.animation_list[self.action][self.frame_index]
        if pygame.time.get_ticks() - self.update_time > animation_cooldown:
            self.update_time = pygame.time.get_ticks()
            self.frame_index += 1
        if self.frame_index >= len(self.animation_list[self.action]):
            self.idle()

    def idle(self):
        self.action = 0
        self.frame_index = 0
        self.update_time = pygame.time.get_ticks()

    def love(self, target):
        self.action = 1
        self.frame_index = 0
        self.update_time = pygame.time.get_ticks()

    def draw(self):
        coinImage = pygame.image.load('img/Icons/coin.png').convert_alpha()
        meatImage = pygame.image.load('img/Icons/Meat.png').convert_alpha()
        meatImage = pygame.transform.scale(meatImage, (40, 40))
        coinImage = pygame.transform.scale(coinImage, (40, 40))
        coin = font.render(str(Gold), True, goldColor)
        food = font.render(str(Food), True, goldColor)
        screen.blit(coin, (750, 75))
        screen.blit(food, (750, 125))
        screen.blit(coinImage, (700, 65))
        screen.blit(meatImage, (700, 115))
        screen.blit(self.image, self.rect)
# CAN BARI


class HealthBar():
    def __init__(self, x, y, hp, max_hp):
        self.x = x
        self.y = y
        self.hp = hp
        self.max_hp = max_hp

    def draw(self, hp):
        self.hp = hp
        ratio = self.hp / self.max_hp
        pygame.draw.rect(screen, red, (self.x, self.y, 150, 20))
        pygame.draw.rect(screen, green, (self.x, self.y, 150 * ratio, 20))
        Health = font.render(str("Can"), True, white)
        screen.blit(Health, (self.x, self.y))
# SEVGİ BARI


class LoveBar():
    def __init__(self, x, y, love, max_love):
        self.x = x
        self.y = y
        self.love = love
        self.max_love = max_love

    def draw(self, love):
        self.love = love
        ratio = self.love / self.max_love
        pygame.draw.rect(screen, red, (self.x, self.y, 150, 20))
        pygame.draw.rect(screen, green, (self.x, self.y, 150 * ratio, 20))
        Love = font.render(str("Sevgi"), True, white)
        screen.blit(Love, (self.x, self.y))
# AÇLIK BARI


class HungryBar():
    def __init__(self, x, y, hungry, max_hungry):
        self.x = x
        self.y = y
        self.hungry = hungry
        self.max_hungry = max_hungry

    def draw(self, hungry):
        self.hungry = hungry
        ratio = self.hungry / self.max_hungry
        pygame.draw.rect(screen, red, (self.x, self.y, 150, 20))
        pygame.draw.rect(screen, green, (self.x, self.y, 150 * ratio, 20))
        hungry = font.render(str("Açlık"), True, white)
        screen.blit(hungry, (self.x, self.y))
# UYKU BARI


class SleepBar():
    def __init__(self, x, y, sleep, max_sleep):
        self.x = x
        self.y = y
        self.sleep = sleep
        self.max_sleep = max_sleep

    def draw(self, sleep):
        self.sleep = sleep
        ratio = self.sleep / self.max_sleep
        pygame.draw.rect(screen, red, (self.x, self.y, 150, 20))
        pygame.draw.rect(screen, green, (self.x, self.y, 150 * ratio, 20))
        sleep = font.render(str("Uyku"), True, white)
        screen.blit(sleep, (self.x, self.y))
# CAN SEVGİ AÇLIK VE UYKU BARLARI


def UIBars():

    petHealt = HealthBar(10, 60, pet.hp, pet.max_hp)
    petLove = LoveBar(10, 100, pet.love, pet.max_love)
    petHungry = HungryBar(10, 140, pet.hungry, pet.max_hungry)
    petSleep = SleepBar(10, 180, pet.sleep, pet.max_sleep)
    petHealt.draw(pet.hp)
    petLove.draw(pet.love)
    petHungry.draw(pet.hungry)
    petSleep.draw(pet.sleep)
# OYUN CAN VE UYKUNUN ZAMANLA AZALMA KISIMLARI


def gameSystem():
    pet.love -= 0.0001
    pet.hungry -= 0.0003
    pet.sleep -= 0.0002
    if(pet.hungry < 5 or pet.sleep < 5):
        pet.hp -= 0.001
        pet.love -= 0.001
    else:
        pass
    if pet.love and pet.hungry and pet.sleep < 0:
        pet.love = 0
        pet.hungry = 0
        pet.sleep = 0
# OYUNDAKİ BUTONLAR VE İŞLEVLERİ


def gameAllBUTTONS():
    petSleep = button(20, 450, 'Uyku')
    petEat = button(200, 450, 'Besle')
    petMarket = button(450, 450, 'Market')
    gold = button(630, 450, 'Para Ver')

    if petSleep.draw_button():

        pet.sleep = pet.max_sleep
        pet.frame_index = 0
        pet.action = 3
        # PetSleepSong.play()

    if petEat.draw_button():
        global Food
        Food -= 1
        pet.frame_index = 0
        pet.action = 2
        pet.hungry += 0.5
        pet.hp += 0.5
        PetEatSong.play()
        if pet.hungry > pet.max_hungry:
            pet.hungry = pet.max_hungry
        if pet.hp > pet.max_hp:
            pet.hp = pet.max_hp

    if petMarket.draw_button():
        Chracter_Save_Files()
    if gold.draw_button():
        pass
# ARKA PLANI ÇİZME


def drawBg():
    screen.blit(bgImage, (0, 0))


def drawStart():
    screen.blit(startImage, (0, 0))
# ALT PANELİ ÇİZME


def drawPanel():
    screen.blit(panelImage, (0, screenHeight - bottomPanel))
# PETİN ÜSTÜNE BASIP SEVME SİSTEMİ


def petLoveSystem():
    global c_clicked
    global Gold
    for event in pygame.event.get():
        if event.type == pygame.MOUSEBUTTONDOWN:
            c_clicked = True
        else:
            c_clicked = False
    pygame.mouse.set_visible(True)
    pos = pygame.mouse.get_pos()
    if pet.rect.collidepoint(pos):
        pygame.mouse.set_visible(False)
        screen.blit(hearth_img, pos)
        if c_clicked == True:
            # PetLoveSong.play()
            Gold += 1
            Chracter_Save_Files()
            pet.love += 1
            pet.action = 1
            c_clicked = False
            if pet.love > pet.max_love:
                pet.love = pet.max_love
# OYUNUN ÇALIŞMASI VE KAPATILMASI


def gameStart():
    global c_clicked
    global run
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            run = False
        if event.type == pygame.MOUSEBUTTONDOWN:
            c_clicked = True
        else:
            c_clicked = False
    pygame.display.update()


def gameLoop():
    drawBg()
    drawPanel()
    UIBars()
    gameSystem()
    gameAllBUTTONS()
    petLoveSystem()
    pet.update()
    pet.draw()
    # gameLoopSong.play()


def Chracter_Save_Files():
    C_Dictionary = {
        "Gold": Gold,
        "Food": Food
    }
    json.dump(C_Dictionary, open("character\player_data.txt", "w"))


# OLUŞTURULAN PET KONUMU MAX CANI UYKUSU SEVGİSİ
pet = gamePet(375, 312, "Kaya", 10, 10, 10, 10)
gameStartKey = 0
run = True

while run:

    gameStart()
    drawStart()
    pressed = pygame.key.get_pressed()
    if pressed[pygame.K_r]:
        gameStartKey = 1
    if gameStartKey > 0:
        gameLoop()
pygame.quit()
