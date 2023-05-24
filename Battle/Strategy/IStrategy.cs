public interface IStrategy
{
    IMachine GetAttakerMachine(IMachine[] machines);
    IMachine GetDefenderMachine(IMachine[] machines);
}