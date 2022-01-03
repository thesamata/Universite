
import pygame as pg

WHITE = (255, 255, 255)
BLACK = (0, 0, 0)
DARKGREY = (40, 40, 40)
LIGHTGREY = (100, 100, 100)
GREEN = (0, 255, 0)
RED = (255, 0, 0)
YELLOW = (255, 255, 0)

# game settings
WIDTH = 800   # 16 * 64 or 32 * 32 or 64 * 16
HEIGHT = 600  # 16 * 48 or 32 * 24 or 64 * 12
FPS = 60
TITLE = "Tilemap Demo"
BGCOLOR = DARKGREY

TILESIZE = 32
GRIDWIDTH = WIDTH / TILESIZE
GRIDHEIGHT = HEIGHT / TILESIZE

# Player settings
PLAYER_SPEED = 300
PLAYER_ROT_SPEED = 250
PLAYER_HIT_RECT = pg.Rect(0, 0, 35, 35)
PLAYER_IMG = 'player.png'

#mob settings
MOB_IMG = 'zombie1.png'


#floor
FLOOR_IMG ='floor_1.png'


#wall
WALL_IMG ='wall1.png'
WALL_DOWN_IMG = 'wall2.png'
WALL_LEFT_IMG = 'wall_left.png'
WALL_RIGHT_IMG = 'wall_right.png'

WALL_LEFT_CORNER_IMG = 'wall_corner_left.png'
WALL_RIGHT_CORNER_IMG = 'wall_corner_right.png'
WALL_LEFT_DOWN_CORNER_IMG = 'wall_corner_down_left.png'
WALL_RIGHT_DOWN_CORNER_IMG = 'wall_corner_down_right.png'
