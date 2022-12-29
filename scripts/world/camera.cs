using Godot;

public class camera : Camera {
    private AnimationPlayer cameraAnimation;

    public override void _Ready() {
        cameraAnimation = GetNode<AnimationPlayer>("anim");
        cameraAnimation.Play("rotate");
    }
}
