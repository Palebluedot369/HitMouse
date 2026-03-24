# -*- encoding=utf8 -*-
__author__ = "adminzzc"

from airtest.core.api import *

auto_setup(__file__)


touch(Template(r"tpl1774366714674.png", record_pos=(0.35, -0.481), resolution=(1080, 1920)))

wait(Template(r"tpl1774366563614.png", record_pos=(0.001, -0.001), resolution=(1920, 1080)))
sleep(2)
touch(Template(r"tpl1774366580617.png", record_pos=(-0.002, -0.001), resolution=(1920, 1080)))


for i in range(5):
    touch(Template(r"tpl1774366599371.png", record_pos=(0.003, 0.001), resolution=(1920, 1080)))
sleep(30)
    
wait(Template(r"tpl1774366628795.png", record_pos=(-0.03, 0.068), resolution=(1920, 1080)))
sleep(3)
touch(Template(r"tpl1774366638664.png", record_pos=(-0.024, 0.066), resolution=(1920, 1080)))

