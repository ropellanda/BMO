git clone https://github.com/BYOBMO/BMO-Utils.git
sudo cp -r /home/pi/BMO-Utils/RetroPie/splashscreens/moco.png /home/pi/RetroPie/splashscreens
sudo cp -r /home/pi/BMO-Utils/RetroPie/bmos-theme/ /etc/emulationstation/themes/
cp /home/pi/BMO-Utils/pi/bashrc ~/.bashrc
pip install SpeechRecognition
cd home/pi/BMO-Utils/voice
mkdir build
cd build
cmake ..
make install
sudo reboot
