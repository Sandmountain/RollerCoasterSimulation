%Initial conditions
y = ones(1,101);
x = zeros(1,101);
vx = zeros(1,101);
vy = zeros(1,101);
ax = zeros(1,100);
ay = zeros(1,100);
speedArray = zeros(1,101);
speedY = zeros(1,101);
%Parameters of simulation
tf = 10.9;
i = 1;
h = 0.1;

%Konstanter
m = 17; %17
C = 0.25;
ro = 1.2;
A = 5;  % 5
g = -9.8;

%% function that defines path shape

%Track Geometry Constants
h_start = 6.7056;
l_end = 32;
b = .055;
w = .7;
p = .3;

path_x = linspace(0, 23, 101);
path_y = (exp(-b*path_x).*(cos(w*path_x - p)) + 2.2*(exp(-(b)*path_x)));
path_y = path_y*(h_start/max(path_y));
path_x = path_x*(l_end/max(path_x));

alpha = atan(diff(path_y)./diff(path_x));
%alpha2 = atan(diff(path_x)./diff(path_y));
%%
i = 1;
direction = 1;
plot(path_x,path_y);
hold on
vx(1) = 0.1;

for t=1:h:tf
    
    % Acceleration framåt
    ax(i) = (g*cos(alpha(i))*sin(alpha(i)))-((C*ro*A*(vx(i)^2)*sign(vx(i))/(2*m)));  % alltid bromsande
    ay(i) = (g*cos(alpha(i))*cos(alpha(i)))-((C*ro*A*(vy(i)^2)*sign(vy(i))/(2*m)));  % alltid bromsande
    %Hastighet framåt
    vx(i+1) = vx(i)+h*ax(i);
    vy(i+1) = vy(i)+h*ay(i);
        
    %plotta uppdatering
    speed = vx(i)*cos(alpha(i));
    p1 = plot(path_x(i), path_y(i), 'og');
    xlabel(['Speed is now ', num2str(round(speed*100)/10), ' km/h'])
    pause(0.2/speed) %uppdaterar med hastigheten av vagnen 
    delete(p1)
    i = i+1;
    
    
end




