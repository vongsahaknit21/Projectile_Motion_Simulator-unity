# Abstract
    In Projectile motion simulation, my purpose is to create the simulation to simulate the motion of a projectile motion. ’’The projectile motion” is the motion of kind of object thrown or projected into the air and the subject to only the acceleration of gravity, It means that is to program the laws of physic into the computer, and then let the computer calculate and show the motion of projectile motion when firing various objects and let user can Set parameters such as angle, initial speed, and mass, and add air resistance to investigate the factors the Acceleration or the change of velocity and the change of direction of an object. furthermore, it can show the object can bound when the user chooses the various landscape Like sand, sand, rock so the object will change the motion during projectile motion. moreover, the paper is going to describe the newly efficient process of “two-dimensional projectile motion” that has both a vertical and horizontal component to the motion, in the same way, the project was created by taking advantage of the formula of projectile motion to observe the effect of these changes upon a variety of projectile parameters such as the range, the maximum height, the time of flight, the time of flight add the top of the parabola,  the angle and the acceleration,  also like use the formula to interpret the current position(X; Y) values and current velocity (Vx; Vy ) values of the projectile during projectile motion.
## Project Structure
There are three main components in order for this solution to be effective:
* A gun (or the source of the projectile in general), using the ray camera (explained below) in conjunction
    with the mouse position on screen to aim. A very simple implementation is already provided.
* A line renderer acting as the trajectory. Just create a line renderer and attach the `Trajectory.cs` script
    to it. The rest are handled by the script. You can adjust any option fits your needs from the __LineRenderer__
    component and change the material.
* A camera. We can use the main camera for this but I prefer to create a new one for this purpose, because
    we can modify it separately. Since all we need is its rotation data we can lower its depth to -100 and even move
    it away from the scene so it doesn't render anything and increases our polygon count for no reason.

## Dependencies
* If the projectile is being shot using the unity engine physics system, you need to add force with the 
    velocity change force mode, as in the provided script:
    ```C#
    g.GetComponent<Rigidbody>().AddForce(g.transform.forward * bulletVelocity, ForceMode.VelocityChange);
    ```
* The trajectory works for position coordinates that the `transform.position.y` is above 0. It also works best for coordinates
    not way above 0. This happens because the arc created starts from a given point until it reaches zero height _(y == 0)_.
    If you must have your projectile source positioned in great height and the trajectory starts looking flat you have to
    increase the **resolution** script variable value from the editor until it looks smooth (also increases the overhead of the 
    calculations). In any other case you have to hack your way around.

## Conclusion

Finally, the project has achieved its objectives. The project has provided students or teachers with do simulation of projectile motion as an example. It provides a more convenient and accurate method for students in school. Consequently, our informal conversations indicated that many students and teachers lack real practice which let them confused with the real experiment. Therefore, we decided to investigate in more detail the projectile. The result of this study will be used to improvement of an existing project that applied the theory to projectile motion in 3D that will help students and teachers do experiment by inserting the various attribute to lunching the projectile. In the future, our projectile motion wants to add more options on different types of landscapes that will make the ball bounds, stuck, deep in various situations.

